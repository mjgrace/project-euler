using System;
using System.Numerics;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            Console.WriteLine((Factorial(n*2) / (Factorial(n) * Factorial(n)))); 
        }

        static double Factorial(int i) {
            double result = 1;
            for (int j = 1; j <= i; j++)
            {
                result *= j;
            }
            return result;
        }
    }
}
