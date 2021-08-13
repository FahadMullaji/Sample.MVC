using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.MVC;

namespace Sample.Test
{
    [TestClass]
    public class BenefitCalculatorTest
    {
        [TestMethod]
        public void CalculateBenefit_WithoutIssue()
        {
            //Assign
            var benefitCalculator = new BenefitCalculator();
            benefitCalculator.BenefitRate = 10;
            benefitCalculator.FAS = 10;
            benefitCalculator.ServiceCredits = 10;

            //Act
            var benefit = benefitCalculator.CalculateBenefit();

            //Assert
            var result = benefit == 1000 ? true : false;
            Assert.IsTrue(result);
        }
    }
}
