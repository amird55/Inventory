using System;
using System.Collections.Generic;
using System.Text;

namespace Pritim
{
    class Process
    {
        private DateTime StartTime;
        private DateTime EndTime;

        public Process(DateTime StartTime, DateTime EndTime)
        {
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }
        public void SetStart(DateTime StartTime)
        {
            this.StartTime = StartTime;
        }

        public void SetEnd(DateTime EndTime)
        {
            this.EndTime = EndTime;
        }

        public TimeSpan CalcTime()
        {
            TimeSpan diff = Convert.ToDateTime(this.EndTime).Subtract(this.StartTime);
            return  diff;
        }

        public Double CalcTimeHours()
        {
            TimeSpan diff = Convert.ToDateTime(this.EndTime).Subtract(this.StartTime);
            return diff.TotalHours;
        }

        public string ToString()
        {
            return "start time = " + this.StartTime + ", end time = " + this.EndTime;
        }
    }
}
