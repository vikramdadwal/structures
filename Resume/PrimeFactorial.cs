using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static class PrimeFactorial
    {
        public static void IsPrimeNumber(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num1 + " is a prime number");

            }
        }

        public static bool IsPowerOfTwo(ulong x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        public static bool AnotherIsPowerOfTwo(int n)
        {
            if (n == 0)
                return false;
            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;
                n = n / 2;
            }
            return true;
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static int AnoitherFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return AnoitherFibonacci(n - 1) + AnoitherFibonacci(n - 2);
        }

        public static void PrintFibnocci(int number, bool type)
        {
            for (int i = 0; i <= number; i++)
            {
                if (type)
                {
                    Console.WriteLine(Fibonacci(i));
                } else
                {
                    Console.WriteLine(AnoitherFibonacci(i));
                }
            }

        }

        public static void FactorialSimple(int number)
        {
            int fact = 1;

            for(int i=1; i<= number; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);

        }

        public static int FactorialRecursive(int number)
        {
            if(number == 0)
            {
                return 1;
            }

            return (number * FactorialRecursive(number - 1));

        }
    }
}
