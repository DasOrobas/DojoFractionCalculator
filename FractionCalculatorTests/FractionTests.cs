using FractionCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FractionCalculatorTests
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod]
        public void InitializesAFraction_ValidValues_PropertiesSet()
        {
            var fraction = new Fraction(3, 4);

            Assert.AreEqual(3, fraction.Numerator);
            Assert.AreEqual(4, fraction.Denominator);
        }

        [TestMethod]
        public void InitializesAFraction_DenominatorIs0_ThrowsDivideByZeroException()
        {
            Exception actualException = null;

            try
            {
                var fraction = new Fraction(3, 0);
            }
            catch (DivideByZeroException ex)
            {
                actualException = ex;                
            }

            Assert.IsNotNull(actualException);                     
        }
    }
}
