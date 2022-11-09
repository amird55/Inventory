using System;

namespace Salary
{
	class SalaryReport
	{
		private readonly Employee employee;

		public SalaryReport(Employee employee)
		{
			this.employee = employee;
		}

		public double GetTotalHours()
		{
			// Defaults to 0
			// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values
			double totalHours;

			for (short i = 0; i < this.employee.GetShifts().Length; i++)
			{
				EmployeeShift shift = this.employee.GetShifts()[i];
				totalHours += Convert.ToDouble(shift.shiftTime());
			}

			return totalHours;
		}

		public double GetSalary()
		{
			return this.employee.salaryPerHour * this.employee.GetTotalHours();
		}

		public override string ToString()
		{
			return string.Format("Salary for {0}: {1}", this.employee.GetFullName(), this.GetSalary());
		}
	}
}