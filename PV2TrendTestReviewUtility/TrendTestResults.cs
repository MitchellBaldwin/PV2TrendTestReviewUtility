using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV2TrendTestReviewUtility
{
    class TrendTestResults
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

        private DateTime testTime;
        public DateTime TestTime
        {
            get { return testTime; }
            set { testTime = value; }
        }

        private double testLength;
        public double TestLength
        {
            get { return testLength; }
            set { testLength = value; }
        }

        private double sampleInterval;
        public double SampleInterval
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

        private MeasuredParameter[] parameters;
        public MeasuredParameter[] Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }

    }
}
