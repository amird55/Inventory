using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amirProject
{
    class Shift
    {
        private DateTime startShift;
        private DateTime endShift;
        private int empId;
        //private Mission missions[];

        public Shift(int empId, DateTime start)
        {
            StreamWriter sw = new StreamWriter("E:/amirProject/amirProject/amirProject/data/now.txt");
            this.startShift = DateTime.Now;
            string tmp = "Shift for:" + empId + " started at:" + this.startShift;
            sw.WriteLine(tmp);
            global::System.Console.WriteLine(tmp);
            sw.Flush();
            sw.Close();
            this.empId = empId;

        }

        public void EndShift()
        {
            this.endShift = DateTime.Now;
        }

        public void setStartShift(DateTime startShift)
        {
            this.startShift = startShift;
        }
        public DateTime getStartShift()
        {
            return startShift;
        }
        public void setEndShift(DateTime endShift)
        {
            this.endShift = endShift;
        }
        public DateTime getEndShift()
        {
            return endShift;
        }
        public void setEmpId(int empId)
        {
            this.empId = empId;
        }
        public int getEmpId()
        {
            return empId;
        }
        public Shift(DateTime startShift, DateTime endShift, int empId)
        {
            this.startShift = startShift;
            this.endShift = endShift;
            this.empId = empId;
        }


        public TimeOnly shiftDurtion() => startShift.TimeOfDay - endShift.TimeOfDay;
    }
}
