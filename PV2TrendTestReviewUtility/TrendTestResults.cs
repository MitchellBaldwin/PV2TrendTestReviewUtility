using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV2TrendTestReviewUtility
{
    public class TrendTestResults
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string serialNumber;
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        private int compliance;
        public int Compliance
        {
            get { return compliance; }
            set { compliance = value; }
        }

        private int resistance;
        public int Resistance
        {
            get { return resistance; }
            set { resistance = value; }
        }

        private double barometricPressure;
        public double BarometricPressure
        {
            get { return barometricPressure; }
            set { barometricPressure = value; }
        }

        private double gasTemperature;
        public double GasTemperature
        {
            get { return gasTemperature; }
            set { gasTemperature = value; }
        }

        private string referenceSystem;
        public string ReferenceSystem
        {
            get { return referenceSystem; }
            set { referenceSystem = value; }
        }
        
        private DateTime testTime;
        public DateTime TestTime
        {
            get { return testTime; }
            set { testTime = value; }
        }

        private TimeSpan testLength;
        public TimeSpan TestLength
        {
            get { return testLength; }
            set { testLength = value; }
        }

        private TimeSpan sampleInterval;
        public TimeSpan SampleInterval
        {
            get { return sampleInterval; }
            set { sampleInterval = value; }
        }

        private int sampleCount;
        public int SampleCount
        {
            get { return sampleCount; }
            set { sampleCount = value; }
        }

        //private MeasuredParameter[] parameters = new MeasuredParameter[24];
        //public MeasuredParameter[] Parameters
        //{
        //    get { return parameters; }
        //    set { parameters = value; }
        //}

        private List<MeasuredParameter> parameters = new List<MeasuredParameter>();
        public List<MeasuredParameter> Parameters
        {
            get { return parameters; }
            //set { parameters = value; }
        }

        public string GetComplianceString()
        {
            if (serialNumber[2].Equals("I"))
            {
                return (compliance / 1000.0).ToString("0.000");
            }
            else
            {
                return (compliance / 100.0).ToString("0.00");
            }
        }

        public string GetResistanceString()
        {
            if (serialNumber[0].Equals("D"))
            {
                //TODO: Update to correctly represent resistor values for Dual Adult lung type
                return "Rp" + resistance.ToString();
            }
            else
            {
                return "Rp" + resistance.ToString();
            }
        }
    }
}
