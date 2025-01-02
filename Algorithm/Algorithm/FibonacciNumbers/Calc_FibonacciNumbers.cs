namespace Algorithm.FibonacciNumbers
{
    public static class Calc_FibonacciNumbers
    {
        public static long Level0(int indx)
        {
            long sum = 0;

            long num1 = 0;
            long num2 = 1;
            for (long i = 0; i < indx; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }

            return sum;
        }

        public static int Level1(int indx)
        {
            if (indx <= 1)
                return 1;
            else 
                return Level1(indx-1) + Level1(indx - 2);
        }
    }
}
