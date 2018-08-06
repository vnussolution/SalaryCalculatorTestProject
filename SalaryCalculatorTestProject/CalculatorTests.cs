using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {


            //arrange
            SalaryCalculator sc = new SalaryCalculator();

            //action
            decimal annualSalary = sc.GetAnnualSalary(50);


            //assert
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
