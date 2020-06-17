using FractionCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionCalculatorTests
{
    [TestClass]
    public class DenominatorHelperTests
    {
        [TestMethod]
        public void FindGreatestCommonDivisor_BiggestValueFirst_RightDivisorReturned()
        {
            var result = DenominatorHelper.FindGreatestCommonDivisor(150, 75);
            Assert.AreEqual(75, result);
        }

        [TestMethod]
        public void FindGreatestCommonDivisor_BiggestValueSecond_RightDivisorReturned()
        {
            var result = DenominatorHelper.FindGreatestCommonDivisor(75, 150);
            Assert.AreEqual(75, result);
        }

        [TestMethod]
        public void FindGreatestCommonDivisor_SameValues_SameValueReturned()
        {
            var result = DenominatorHelper.FindGreatestCommonDivisor(4, 4);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindGreatestCommonDivisor_WithPrimeNumber_OneReturned()
        {
            var result = DenominatorHelper.FindGreatestCommonDivisor(7, 13);
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void FindGreatestCommonDivisor_NegativeValue1_PositiveDividerReturned()
        {
            var result = DenominatorHelper.FindGreatestCommonDivisor(-7, 13);
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void FindGreatestCommonDivisor_NegativeValue2_PositiveDividerReturned()
        {
            var result = DenominatorHelper.FindGreatestCommonDivisor(7, -13);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindLeastCommonMultiple_MultipleOf5_BiggerValueReturned()
        {
            var result = DenominatorHelper.FindLeastCommonMultiple(5, 10);
            Assert.AreEqual(10, result);

            var result2 = DenominatorHelper.FindLeastCommonMultiple(5, 25);
            Assert.AreEqual(25, result2);
        }

        [TestMethod]
        public void FindLeastCommonMultiple_NegativeValues_NegativeValueIgnored()
        {
            var result = DenominatorHelper.FindLeastCommonMultiple(-5, 10);
            Assert.AreEqual(10, result);

            var result2 = DenominatorHelper.FindLeastCommonMultiple(5, -25);
            Assert.AreEqual(25, result2);

            var result3 = DenominatorHelper.FindLeastCommonMultiple(-5, -25);
            Assert.AreEqual(25, result3);
        }

        [TestMethod]
        public void FindLeastCommonMultiple_PrimeValues_MultipliesBothNumber()
        {
            var result = DenominatorHelper.FindLeastCommonMultiple(7, 13);
            Assert.AreEqual(91, result);
        }
    }
}
