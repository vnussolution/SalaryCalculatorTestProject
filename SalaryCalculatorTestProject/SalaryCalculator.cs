namespace SalaryCalculatorTestProject
{
    internal class SalaryCalculator
    {

        public decimal Salary { get; private set; }

        public decimal GetAnnualSalary(int i)
        {
            const decimal hoursInOneYear = 2080;
            this.Salary = 50 * hoursInOneYear;
            return Salary;
        }
    }
}