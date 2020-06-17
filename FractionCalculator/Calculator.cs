namespace FractionCalculator
{
    public static class Calculator
    {
        public static Fraction Add(Fraction firstFraction, Fraction secondFraction)
        {
            var leastCommonMultiple = DenominatorHelper.FindLeastCommonMultiple(firstFraction.Denominator, secondFraction.Denominator);
            
            int newNumerator = firstFraction.Numerator * (leastCommonMultiple / firstFraction.Denominator) + secondFraction.Numerator * (leastCommonMultiple / secondFraction.Denominator);
            
            var greatestCommonFactor = DenominatorHelper.FindGreatestCommonDivisor(newNumerator, leastCommonMultiple);

            return new Fraction(newNumerator/greatestCommonFactor, leastCommonMultiple/greatestCommonFactor);
        }

        public static Fraction Multiply(Fraction firstFraction, Fraction secondFraction)
        {
            int newDenominator = firstFraction.Denominator * secondFraction.Denominator;

            int newNumerator = firstFraction.Numerator * secondFraction.Numerator;

            var greatestCommonFactor = DenominatorHelper.FindGreatestCommonDivisor(newNumerator, newDenominator);

            return new Fraction(newNumerator/greatestCommonFactor, newDenominator/greatestCommonFactor);
        }

        public static Fraction Substract(Fraction firstFraction, Fraction secondFraction)
        {
            var leastCommonMultiple = DenominatorHelper.FindLeastCommonMultiple(firstFraction.Denominator, secondFraction.Denominator);

            int newNumerator = firstFraction.Numerator * (leastCommonMultiple / firstFraction.Denominator) - secondFraction.Numerator * (leastCommonMultiple / secondFraction.Denominator);

            var greatestCommonFactor = DenominatorHelper.FindGreatestCommonDivisor(newNumerator, leastCommonMultiple);

            return new Fraction(newNumerator/greatestCommonFactor, leastCommonMultiple/greatestCommonFactor);
        }


        public static Fraction Divide(Fraction firstFraction, Fraction secondFraction)
        {           
                int newNumerator = firstFraction.Numerator * secondFraction.Denominator;

                int newDenominator = firstFraction.Denominator * secondFraction.Numerator;

                var greatestCommonFactor = DenominatorHelper.FindGreatestCommonDivisor(newNumerator, newDenominator);

                return new Fraction(newNumerator / greatestCommonFactor, newDenominator / greatestCommonFactor);
        }

    }
}
