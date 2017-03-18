//---------------------------------------------------------------------------
#include <vcl\vcl.h>
#include "TPVMain.h"
#pragma hdrstop

#include "TTrendTest.h"

TTrendTest::TTrendTest()
{
  Name = "";
  StartTime = 0;
  Length = 25920000;     // 72 hours in centiseconds
  SampleLength = 1500;   // one quarter minute in centiseconds
  TotalSamples = 17281;  // 72 hours @ 1 sample / 15s

  LastSample = 0;
  Modified = true;
  FirstTime = true;

  FileName = ChangeFileExt(PVMain->ProjectFileName, String(""));
  FileName = FileName + String("Trend01.ttr");

  // Size Trend Data array to hold the maximum possible number of
  // data points ( 1 sample every 15s, 72 hour test ):
  TrendData.resize(MAX_PARAMETER);
  for (int i=0; i<MAX_PARAMETER; i++) TrendData[i].resize(TotalSamples);

  // Initialize Traget values for all parameters:
  DataValue* DV = PVMain->DataValues;
  for(int i=0; i<MAX_PARAMETER; i++)
  {
    Targets[i].Min = DV->ParamDefs[i]->MinValue;
    Targets[i].Max = DV->ParamDefs[i]->MaxValue;
    Targets[i].Avg = (Targets[i].Min + Targets[i].Max) / 2;
    Results[i].Min = DV->ParamDefs[i]->MaxValue;
    Results[i].Max = DV->ParamDefs[i]->MinValue;
    Results[i].Avg = 0;
    Results[i].tMin = 0;
    Results[i].tMax = 0;
  }
}

//---------------------------------------------------------------------------
TTrendTest::TTrendTest(String name, long length, long sampleLength)
{
  Name = name;
  StartTime = 0;
  Length = length;
  SampleLength = sampleLength;

  TotalSamples = Length / SampleLength + 1;

  LastSample = 0;
  Modified = true;
  FirstTime = true;

  FileName = ChangeFileExt(PVMain->ProjectFileName, String(""));
  FileName = FileName + Name + String(".ttr");

  TrendData.resize(MAX_PARAMETER);
  for (int i=0; i<MAX_PARAMETER; i++) TrendData[i].resize(TotalSamples);

  // Initialize Traget values for all parameters:
  TTemplate* CT = PVMain->CurrentTemplate;
  for(int i=0; i<MAX_PARAMETER; i++)
  {
    Targets[i].Min = CT->TrendInfo.Targets[i].Min;
    Targets[i].Max = CT->TrendInfo.Targets[i].Max;
    Targets[i].Avg = CT->TrendInfo.Targets[i].Avg;

    Results[i].Min = PVMain->DataValues->ParamDefs[i]->MaxValue;
    Results[i].Max = PVMain->DataValues->ParamDefs[i]->MinValue;
    Results[i].Avg = 0;
    Results[i].tMin = 0;
    Results[i].tMax = 0;
  }
}

//---------------------------------------------------------------------------

TTrendTest::~TTrendTest()
{

}
//---------------------------------------------------------------------------

void TTrendTest::SaveTemplateData(void)
{
  TTemplate *CT = PVMain->CurrentTemplate;

  strcpy(CT->TrendInfo.Name, Name.c_str());
  strcpy(CT->TrendInfo.FileName, FileName.c_str());
  CT->TrendInfo.StartTime = StartTime;
  CT->TrendInfo.Length = Length;
  CT->TrendInfo.SampleLength = SampleLength;
  CT->TrendInfo.TotalSamples = TotalSamples;

  CT->TrendInfo.Modified = Modified;
  CT->TrendInfo.FirstTime = FirstTime;

  for (int i=0; i<MAX_PARAMETER; i++)
  {
    CT->TrendInfo.Targets[i].Min = Targets[i].Min;
    CT->TrendInfo.Targets[i].Avg = Targets[i].Avg;
    CT->TrendInfo.Targets[i].Max = Targets[i].Max;
  }
}
//---------------------------------------------------------------------------

void TTrendTest::Resize()
{
  for (int i=0; i<MAX_PARAMETER; i++) TrendData[i].resize(TotalSamples);

}
//---------------------------------------------------------------------------

void TTrendTest::AddSample(long time, int min, int avg, int max, int Param)
{
  int sample = (time - StartTime) / SampleLength;
  if (FirstTime)
  {
    TrendData[Param][0].Min = Targets[Param].Avg;
    TrendData[Param][0].Avg = Targets[Param].Avg;
    TrendData[Param][0].Max = Targets[Param].Avg;
    if (Param == MAX_PARAMETER-1) FirstTime = false;
  }
  if (sample < TotalSamples)
  {
    TrendData[Param][sample].Min = min;

    // Temporary fix of a bug that sometimes causes the second sample
    //(sample #1) to be significantly lower than actual...
    if (sample == 1) TrendData[Param][sample].Avg = (max + min) / 2;
    else TrendData[Param][sample].Avg = avg;

    TrendData[Param][sample].Max = max;
  }
  LastSample = sample;

  Modified = true;
}

//---------------------------------------------------------------------------
void TTrendTest::GetSample(long time, int& min, int& avg, int& max, int Param)
{
  int sample = (time - StartTime) / SampleLength;
  if (sample <= LastSample)
  {
     min = TrendData[Param][sample].Min;
     avg = TrendData[Param][sample].Avg;
     max = TrendData[Param][sample].Max;
  }
  else
  {
    min = 0;
    avg = 0;
    max = 0;
  }
}

//---------------------------------------------------------------------------
bool __fastcall TTrendTest::EndOfTest(long time)
{
  if ((time-StartTime) > Length) return true;
  else return false;
}

//---------------------------------------------------------------------------
bool TTrendTest::SaveToFile(String fileName)
{
  ofstream textfile(fileName.c_str());
  if (!textfile)
  {
    Application->MessageBox("Could not create requested trend data results file",
                            "File Error", MB_OK | MB_ICONWARNING);
    return false;
  }
  FileName = fileName;
  textfile << Name.c_str() << endl;
  textfile << FileName.c_str() << endl;
  textfile << StartTime << endl;
  textfile << Length << endl;
  textfile << SampleLength << endl;
  textfile << LastSample << endl;

  // Need to save targets & overall results here
  for (int i=0; i<MAX_PARAMETER; i++)
  {
    textfile << Targets[i].Min << endl;
    textfile << Targets[i].Avg << endl;
    textfile << Targets[i].Max << endl;
    textfile << UserOverride[i] << endl;
    textfile << Results[i].Min << endl;
    textfile << Results[i].Avg << endl;
    textfile << Results[i].Max << endl;
    textfile << Results[i].tMin << endl;
    textfile << Results[i].tMax << endl;
  }

  textfile.close();

  TRENDDATA Record;
  fileName = ChangeFileExt(fileName, String(".ttd"));
  ofstream outfile(fileName.c_str(), ios::binary);
  if (!outfile)
  {
    Application->MessageBox("Could not create requested trend data file",
                            "File Error", MB_OK | MB_ICONWARNING);
    return false;
  }
  for(int Param=0; Param<MAX_PARAMETER; Param++)
  {
    for(int i=0; i<TotalSamples; i++)
    {
      Record = TrendData[Param][i];
      outfile.write((char*)&Record, sizeof(Record));
    }
  }
  outfile.close();

  Modified = false;

  return true;

}
//---------------------------------------------------------------------------

bool TTrendTest::LoadFromFile(String fileName)
{
  char buff[256];

  ifstream textfile(fileName.c_str());
  if (!textfile)
  {
    Application->MessageBox("Could not open requested trend data results file",
                            "File Error", MB_OK | MB_ICONWARNING);
    return false;
  }
  //textfile >> buff;
  textfile.getline(buff, sizeof(buff));
  Name = String(buff);
  //textfile >> buff;
  textfile.getline(buff, sizeof(buff));
  FileName = String(buff);
  textfile >> StartTime;
  textfile >> Length;
  textfile >> SampleLength;
  TotalSamples = Length / SampleLength + 1;
  textfile >> LastSample;

  // Read in overall results here
  for (int i=0; i<MAX_PARAMETER; i++)
  {
    textfile >> Targets[i].Min;
    textfile >> Targets[i].Avg;
    textfile >> Targets[i].Max;
    textfile >> UserOverride[i];
    textfile >> Results[i].Min;
    textfile >> Results[i].Avg;
    textfile >> Results[i].Max;
    textfile >> Results[i].tMin;
    textfile >> Results[i].tMax;
  }

  TRENDDATA  Record;
  fileName = ChangeFileExt(fileName, String(".ttd"));
  ifstream infile(fileName.c_str(), ios::binary);
  if (!infile)
  {
    Application->MessageBox("Could not open requested trend data file",
                            "File Error", MB_OK | MB_ICONWARNING);
    return false;
  }

  for(int Param=0; Param<MAX_PARAMETER; Param++)
  {
    for(int i=0; i<TotalSamples; i++)
    {
      infile.read((char*)&Record, sizeof(Record));
      TrendData[Param][i].Min = Record.Min;
      TrendData[Param][i].Avg = Record.Avg;
      TrendData[Param][i].Max = Record.Max;
    }
  }
  infile.close();

  Modified = false;

  return true;
}
//---------------------------------------------------------------------------

#pragma package(smart_init)
