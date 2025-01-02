using System;

namespace Algorithm.LatestCommonMultiplier
{
    public static class Calc_LatestCommonMultiplier
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
            int[] LCM_Lst1 = new int[max];
            int[] LCM_Lst2 = new int[max];
            int LCM = min * max;
            for (int n = 1; n <= max; n++)
            {
                bool flag = false;
                LCM_Lst1[n - 1] = min * n;
                LCM_Lst2[n - 1] = max * n;

                for (int i = 0; i< n; i ++)
                {
                    flag = (LCM_Lst2[i] == min * n || LCM_Lst1[i] == max * n);
                    if (flag)
                    {
                        if(LCM_Lst2[i] == min * n)
                        {
                            LCM = min * n;
                        }
                        else
                        {
                            LCM = max * n;
                        }
                        break;
                    }
                }
                if(flag)
                {
                    break;
                }
            }
            return LCM;
        }
        
        private static long gcd(long num1, long num2)
        {
            if (num1 == 0) { return num2; }
            else if (num2 == 0) { return num1; }
            long max = num1;
            long min = num2;

            if (num2 > num1)
            {
                max = num2;
                min = num1;
            }
            return gcd(max % min, min);
        }
        public static long Level1(long num1, long num2)
        {
            long max = num1;
            long min = num2;
            if (num2 > num1)
            {
                max = num2;
                min = num1;
            }
            long _gcd = gcd(min, max);
            return _gcd * (min / _gcd) * (max / _gcd);
        }
    }
}
