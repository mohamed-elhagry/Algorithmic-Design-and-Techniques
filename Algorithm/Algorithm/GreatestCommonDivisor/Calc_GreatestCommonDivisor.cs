using System;

namespace Algorithm.GreatestCommonDivisor
{
    public static class Calc_GreatestCommonDivisor
    {
        public static int Level0(int num1, int num2)
        {
            int max = num1;
            int min = num2;
            if(num2 > num1)
            {
                max = num2;
                min = num1;
            }

            for (int GCD = min; GCD > 0; GCD--)
            {
                if(max% GCD == 0 && min % GCD == 0)
                    return GCD;

            }
            return 1;
        }
        public static int Level1(int num1, int num2)
        {
            if(num1 == 0) {  return num2; }
            else if(num2 == 0) {  return num1; }
            int max = num1;
            int min = num2;
            if (num2 > num1)
            {
                max = num2;
                min = num1;
            }

            return Level1(max% min, min);
        }
    }
}
