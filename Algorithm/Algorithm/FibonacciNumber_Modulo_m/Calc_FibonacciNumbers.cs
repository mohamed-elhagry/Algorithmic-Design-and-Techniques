namespace Algorithm.FibonacciNumber_Modulo_m
{
    public static class FibonacciNumber_Modulo_m
    {
        static private long Calc_Modulo_m_Range(long n, long m)
        {
            long mx_length = m * m;//4
            
            long sum = 0;

            long num1 = 0;
            long num2 = 1;

            long Modulo_m_index = 0;
            for (int i = 1; i < mx_length; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum % m;
                
                if(num2 == 0 && num1 == 1)
                {
                    Modulo_m_index = (n % (i+1));
                    if(Modulo_m_index == 0)
                    {
                        Modulo_m_index = i + 1;
                    }
                    break;
                }
            }
            sum = 0;
            
            num1 = 0;
            num2 = 1;
            long res = 1;
            for (int _i = 1;  _i < Modulo_m_index; _i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum % m;
                res = num2;

            }
            return res;
        }
        static public long Calc_Fi_modulo_m(long indx, long m)
        {
            return Calc_Modulo_m_Range(indx, m);
        }
    }
}
/*
 #include <iostream>

unsigned long long int get_fibonacci_huge_naive(unsigned long long int n, unsigned long long int m) {
    unsigned long long int mx_length = m*m;//4
    
    unsigned long long int sum = 0;

 	unsigned long long int num1 = 0;
 	unsigned long long int num2 = 1;
 	
    unsigned long long int  Modulo_m_index = 0;
    for (int i = 1; i < mx_length; i++)
	{
    	sum = num1 + num2;
    	num1 = num2;
    	num2 = sum % m;
    	if(i >= 3 && num2 == 0 && num1 == 1)
        {
         	Modulo_m_index = n% (i+1);
         	break;
    	}
	}
    sum = 0;

 	num1 = 0;
 	num2 = 1;
    unsigned long long int res = 1;
    for (int i = 1; i < Modulo_m_index; i++)
	{
    	sum = num1 + num2;
    	num1 = num2;
    	num2 = sum % m;
        res = num2;
    	
	}
    return res;
}

int main() {
    unsigned long long int n, m;
    std::cin >> n >> m;
    std::cout << get_fibonacci_huge_naive(n, m) << '\n';
 
 	return 0;
}

 */