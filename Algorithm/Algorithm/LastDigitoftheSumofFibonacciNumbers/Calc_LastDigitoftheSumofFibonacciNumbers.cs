using System;

namespace Algorithm.LastDigitoftheSumofFibonacciNumbers
{
    public static class Calc_LastDigitoftheSumofFibonacciNumbers
    {
        private static long Calc_FibonacciNumbers(long indx)
        {
            long Fi = 1;

            long num1 = 0;
            long num2 = 1;
            for (long i = 1; i < indx; i++)
            {
                Fi = num1 + num2;
                num1 = num2;
                num2 = Fi;
            }

            return Fi;
        }
        public static long Level0(long num)
        {
            long sum = 0;
            for (long i = 1; i <= num; i++)
            {
                sum += Calc_FibonacciNumbers(i);
            }

            return sum % 10;
        }
        public static long Level1(long indx)
        {
            long Fi = 1;
            long sum = 1;

            long num1 = 0;
            long num2 = 1;
            for (long i = 1; i < indx; i++)
            {
                Fi = num1 + num2;
                sum += Fi;
                num1 = num2;
                num2 = Fi;
            }
            if(indx == 0) { sum  = 0; }
            return sum%10;
        }
    }
}
/*
#include <iostream>

int fibonacci_sum_naive(long long indx) {
    long long Fi = 1;
    long long sum = 1;

    long long num1 = 0;
    long long num2 = 1;
    for (long long i = 1; i < indx; i++)
    {
        Fi = num1 + num2;
        sum += Fi;
        num1 = num2;
        num2 = Fi;
    }
    return sum%10;
}

int main() {
    long long n = 0;
    std::cin >> n;
    std::cout << fibonacci_sum_naive(n);
 
 	return 0;
}

 */