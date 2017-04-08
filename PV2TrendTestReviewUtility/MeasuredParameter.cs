using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PV2TrendTestReviewUtility
{
    class MeasuredParameter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int precision;
        public int Precision
        {
            get { return precision; }
            set { precision = value; }
        }

        private string units;
        public string Units
        {
            get { return units; }
            set { units = value; }
        }

        private double lowLimit;
        public double LowLimit
        {
            get { return lowLimit; }
            set { lowLimit = value; }
        }

        private double target;
        public double Target
        {
            get { return target; }
            set { target = value; }
        }

        private double highLimit;
        public double HighLimit
        {
            get { return highLimit; }
            set { highLimit = value; }
        }

        private double minimumMeasurement;
        public double MinimumMeasurement
        {
            get { return minimumMeasurement; }
            set { minimumMeasurement = value; }
        }

        private double averageMeasurement;
        public double AverageMeasurement
        {
            get { return averageMeasurement; }
            set { averageMeasurement = value; }
        }

        private double maximumMeasurement;
        public double MaximumMeasurement
        {
            get { return maximumMeasurement; }
            set { maximumMeasurement = value; }
        }

        private TimeSpan minTime;
        public TimeSpan MinTime
        {
            get { return minTime; }
            set { minTime = value; }
        }

        private TimeSpan maxTime;
        public TimeSpan MaxTime
        {
            get { return maxTime; }
            set { maxTime = value; }
        }

    }
}
