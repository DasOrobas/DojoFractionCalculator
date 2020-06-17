using System;

namespace FractionCalculator
{
    public static class DenominatorHelper
    {
        public static int FindGreatestCommonDivisor(int a, int b)
        {
            int absoluteValue1 = Math.Abs(a);
            int absoluteValue2 = Math.Abs(b);
            while (absoluteValue1 != 0 && absoluteValue2 != 0)
            {
                if (absoluteValue1 > absoluteValue2)
                {
                    absoluteValue1 = absoluteValue1 % absoluteValue2;
                }
                else
                {
                    absoluteValue2 = absoluteValue2 % absoluteValue1;
                }
                    
            }
            return Math.Max(absoluteValue1, absoluteValue2);
        }
        public static int FindLeastCommonMultiple(int a, int b)
        {
            int absoluteValue1 = Math.Abs(a);
            int absoluteValue2 = Math.Abs(b);

            return absoluteValue1 * absoluteValue2 / FindGreatestCommonDivisor(absoluteValue1, absoluteValue2);
        }
    }
}
