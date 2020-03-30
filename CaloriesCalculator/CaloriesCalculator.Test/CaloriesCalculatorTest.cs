using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaloriesCalculator.Test
{
    [TestClass]
    public class CaloriesCalculatorTest
    {
        [TestMethod]
        public void TestMaleCaculator()
        {
            CaloriesCalculator caloriesCalculator = new CaloriesCalculator();
            var got = caloriesCalculator.CalculateCalories(110M, 5M, 1M, 12M, "Male");
            var expected = 1606.2M;
            Assert.AreEqual(got, expected);
        }

        [TestMethod]
        public void TestFeMaleCaculator()
        {
            CaloriesCalculator caloriesCalculator = new CaloriesCalculator();
            var got = caloriesCalculator.CalculateCalories(110M, 5M, 1M, 12M, "FeMale");
            var expected = 1410.0M;
            Assert.AreEqual(got, expected);
        }

    }
}
