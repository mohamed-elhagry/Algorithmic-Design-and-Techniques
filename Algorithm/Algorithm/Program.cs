// See https://aka.ms/new-console-template for more information

using Algorithm.FibonacciNumber_Modulo_m;
using Algorithm.FibonacciNumbers;
using Algorithm.GreatestCommonDivisor;
using Algorithm.LastDigitoftheSumofFibonacciNumbers;
using Algorithm.LatestCommonMultiplier;
using System;

//Console.WriteLine(Calc_FibonacciNumbers.Level0(8));
//Console.WriteLine(Calc_FibonacciNumbers.Level1(1000));

//Console.WriteLine(Calc_GreatestCommonDivisor.Level0(63,64));
//Console.WriteLine(Calc_LatestCommonMultiplier.Level1(14159572,63967072));//1619590880   226436590403296
/*for (int i = 0; i < 10; i++)
{
    int _base = 2;
    int _num = i ;
    Console.Write(_num + "," + _base+ " ==> ");
    Console.WriteLine(FibonacciNumber_Modulo_m.Calc_Fi_modulo_m(_num, _base));
}*/
/*Console.WriteLine(FibonacciNumber_Modulo_m.Calc_Fi_modulo_m(9, 2));//0
Console.WriteLine(FibonacciNumber_Modulo_m.Calc_Fi_modulo_m(7, 3));//1
Console.WriteLine(FibonacciNumber_Modulo_m.Calc_Fi_modulo_m(2015, 3));//1
Console.WriteLine(FibonacciNumber_Modulo_m.Calc_Fi_modulo_m(239, 1000));//161
Console.WriteLine(FibonacciNumber_Modulo_m.Calc_Fi_modulo_m(2816213588,239));//151
*/
//Console.WriteLine(Calc_LastDigitoftheSumofFibonacciNumbers.Level1(1));//1
//Console.WriteLine(Calc_LastDigitoftheSumofFibonacciNumbers.Level1(2));//2
Console.WriteLine(Calc_LastDigitoftheSumofFibonacciNumbers.Level1(100));//4
//Console.WriteLine(Calc_LastDigitoftheSumofFibonacciNumbers.Level1(4));//7
//Console.WriteLine(Calc_LastDigitoftheSumofFibonacciNumbers.Level1(5));//12
//Console.WriteLine(Calc_LastDigitoftheSumofFibonacciNumbers.Level1(6));//20
/*

#include <iostream>

#include <iostream>

long gcd(long num1, long num2)
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
long lcm(long num1, long num2)
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
int main()
{
    long num1, num2;
    std::cin >> num1 >> num2;
    std::cout << lcm(num1, num2);

    return 0;
}*/