using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            bool matchFound = false;

            for (num = 1; !matchFound; num++) {
                for (int j = 1; num % j == 0 && j <= 20; j++){
                    if (j == 20) {
                        matchFound = true;
                        Console.WriteLine(num);
                    }
                }
            }
        }
    }
}
