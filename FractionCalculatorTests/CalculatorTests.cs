using FractionCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTwoFractions_CommonDenominator_FractionsCorrectlyAddedAndSimplified()
        {
            var fraction = new Fraction(3, 4);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Add(fraction, fraction2);
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(1, result.Denominator);
        }

        [TestMethod]
        public void AddTwoFractions_TwoDifferentPrimeDenominators_FractionsReturnedWithLeastCommonDenominator()
        {
            var fraction = new Fraction(12, 7);
            var fraction2 = new Fraction(10, 13);

            var result = Calculator.Add(fraction, fraction2);
            Assert.AreEqual(226, result.Numerator);
            Assert.AreEqual(91, result.Denominator);
        }

        [TestMethod]
        public void AddTwoFractions_NonCommonDenominator_FractionsReturnedWithLeastCommonDenominator()
        {
            var fraction = new Fraction(5, 22);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Add(fraction, fraction2);
            Assert.AreEqual(44, result.Denominator);
            Assert.AreEqual(21, result.Numerator);
        }

        [TestMethod]
        public void AddTwoFractions_NonCommonDenominatorWithNegativeResult_FractionsReturnedWithLeastCommonDenominator()
        {
            var fraction = new Fraction(-7, 22);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Add(fraction, fraction2);
            Assert.AreEqual(44, result.Denominator);
            Assert.AreEqual(-3, result.Numerator);
        }

        [TestMethod]
        public void MultipleTwoFractions_ResultNonReduceable_FractionsCorrectlyMultiplied()
        {
            var fraction = new Fraction(3, 4);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Multiply(fraction, fraction2);
            Assert.AreEqual(3, result.Numerator);
            Assert.AreEqual(16, result.Denominator);
        }

        [TestMethod]
        public void MultipleTwoFractions_ResultReduceable_FractionsCorrectlyMultipliedAndReduced()
        {
            var fraction = new Fraction(2, 4);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Multiply(fraction, fraction2);
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(8, result.Denominator);
        }

        [TestMethod]
        public void MultiplytTwoFractions_CommonDenominatorAndNegativeResult_FractionsCorrectlySubstractedAndReduced()
        {
            var fraction = new Fraction(-3, 4);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Multiply(fraction, fraction2);
            Assert.AreEqual(-3, result.Numerator);
            Assert.AreEqual(16, result.Denominator);
        }

        [TestMethod]
        public void SubstractTwoFractions_CommonDenominator_FractionsCorrectlySubstractedAndReduced()
        {
            var fraction = new Fraction(3, 4);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Substract(fraction, fraction2);
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(2, result.Denominator);
        }

        [TestMethod]
        public void SubstractTwoFractions_TwoDifferentPrimeDenominators_FractionsReturnedWithLeastCommonDenominator()
        {
            var fraction = new Fraction(12, 7);
            var fraction2 = new Fraction(10, 13);

            var result = Calculator.Substract(fraction, fraction2);
            Assert.AreEqual(86, result.Numerator);
            Assert.AreEqual(91, result.Denominator);
        }

        [TestMethod]
        public void SubstractTwoFractions_NonCommonDenominatorAndNegativeValue_FractionsReturnedWithLeastCommonDenominator()
        {
            var fraction = new Fraction(5, 22);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Substract(fraction, fraction2);
            Assert.AreEqual(44, result.Denominator);
            Assert.AreEqual(-1, result.Numerator);

        }

        [TestMethod]
        public void DivideTwoFractions_ResultNonReduceable_FractionsCorrectlyDivided()
        {
            var fraction = new Fraction(5, 3);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Divide(fraction, fraction2);
            Assert.AreEqual(20, result.Numerator);
            Assert.AreEqual(3, result.Denominator);
        }

        [TestMethod]
        public void DividewoFractions_ResultReduceable_FractionsCorrectlyDividedAndReduced()
        {
            var fraction = new Fraction(2, 4);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Divide(fraction, fraction2);
            Assert.AreEqual(2, result.Numerator);
            Assert.AreEqual(1, result.Denominator);
        }

        [TestMethod]
        public void DividewoFractions_NegativeResult_FractionsCorrectlyDividedAndReduced()
        {
            var fraction = new Fraction(-2, 4);
            var fraction2 = new Fraction(1, 4);

            var result = Calculator.Divide(fraction, fraction2);
            Assert.AreEqual(-2, result.Numerator);
            Assert.AreEqual(1, result.Denominator);
        }

    }
}
