using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fib_1 = 1;
            int fib_2 = 2;

            while (fib_2 < 4_000_000)
            {
                if (fib_2 % 2 ==0)
                {
                    sum += fib_2;
                }
                int temp = fib_2;
                fib_2 = fib_1 + fib_2;
                fib_1 = temp;
            }
            Console.WriteLine(sum);
        }
    }
}
