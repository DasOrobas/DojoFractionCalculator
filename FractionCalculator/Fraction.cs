using System;

namespace FractionCalculator
{
    public class Fraction
    {

        public int Numerator { get; private set; }

        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new DivideByZeroException();
            }

            this.Numerator = numerator;
            this.Denominator = denominator;
        }        
    }
}
