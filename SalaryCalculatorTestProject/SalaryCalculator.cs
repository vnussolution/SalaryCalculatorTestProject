namespace SalaryCalculatorTestProject
{
    internal class SalaryCalculator
    {

        public decimal Salary { get; private set; }

        public decimal GetAnnualSalary(int i)
        {
            this.Salary = i * 201;
            return Salary;
        }
    }
}