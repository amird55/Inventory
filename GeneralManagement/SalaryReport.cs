using System;

namespace Items
{
    class SalaryReport
    {
        private readonly Employee employee;

        public SalaryReport(Employee employee)
        {
            this.employee = employee;
        }

        public double GetSalary()
        {
            double totalHours = 0;
            for (int i = 0; i < this.employee.shift.Length; i++)
            {
                totalHours += this.employee.shift[i].shiftTime();
            }
            return this.employee.salaryPerHour * totalHours;
        }

        public override string ToString()
        {
            return string.Format("Salary for {0}: {1}", this.employee.fullName, this.GetSalary());
        }
    }
}