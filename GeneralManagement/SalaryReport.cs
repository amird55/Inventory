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

		public double TotalWorkHours(DateTime dateTime)
		{
			// Defaults to 0
			// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values
			double totalHours;

			// Returns all shift objects in month of datetime
			Shift[] shifts = this.employee.GetShifts(dateTime);

			// Increments totalHours by the shift time for each shift
			for (short i = 0; i < shifts.Length; i++)
			{
				EmployeeShift shift = shifts[i];
				totalHours += Convert.ToDouble(shift.shiftTime());
			}

			return totalHours;
		}

		// Returns monthly salary for this employee
		public double GetSalary(DateTime dateTime = DateTime.Now)
		{
			return this.employee.GetSalaryPerHour() * this.TotalWorkHours(dateTime);
		}

		public override string ToString()
		{
			return string.Format("Salary for {0}: {1}",
				this.employee.GetFullName(),
				this.GetSalary()
			);
		}
	}
}