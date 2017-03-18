//---------------------------------------------------------------------------
#ifndef TTrendTestH
#define TTrendTestH

#include <vcl/vcl.h>
#include <vector.h>
#include <fstream.h>
#pragma hdrstop
#include "TParamDef.h"

typedef struct _TRENDDATA
{
  int Min;        // Minimum value for sample interval
  int Avg;        // Average value for sample interval
  int Max;        // Maximum value for sample interval
} TRENDDATA;

typedef struct _TRENDRESULT
{
  int Min;        // Minimum value for entire test
  int Avg;        // Average value for entire test
  int Max;        // Maximum value for entire test
  long tMin;      // Time at which minimum occurred
  long tMax;      // Time at which maximum occurred
} TRENDRESULT;

typedef struct _TRENDINFO
{
  char Name[32];
  char FileName[256];
  long StartTime;
  long Length;
  long SampleLength;
  int TotalSamples;

  bool Modified;
  bool FirstTime;

  TRENDDATA Targets[MAX_PARAMETER];   // Holds Traget and upper & lower bounds
} TRENDINFO;

class TTrendTest
{
  private:

  public:
    String Name;
    String FileName;
    long StartTime;
    long Length;
    long SampleLength;
    int TotalSamples;

    int LastSample;                     // Hold number of samples actually received
    bool Modified;
    bool FirstTime;

    TRENDDATA Targets[MAX_PARAMETER];   // Holds Traget and upper & lower bounds
    bool UserOverride[MAX_PARAMETER];   // true if user changes Target value
    TRENDRESULT Results[MAX_PARAMETER]; // Holds Min, Avg & Max for the entire test
    std::vector < std::vector < TRENDDATA > > TrendData;

    TTrendTest();
    TTrendTest(String name, long length, long sampleLength);
    virtual ~TTrendTest();
    void Resize();
    void AddSample(long time, int min, int avg, int max, int Param);
    void GetSample(long time, int& min, int& avg, int& max, int Param);
    bool __fastcall EndOfTest(long time);
    bool SaveToFile(String fileName);
    bool LoadFromFile(String fileName);
    void SaveTemplateData(void);

};

//---------------------------------------------------------------------------
#endif
 