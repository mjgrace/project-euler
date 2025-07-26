using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sundays = 0;

            DateTime date1 = new DateTime(1901, 1, 1);
            DateTime date2 = new DateTime(2000, 12, 31);

            for (DateTime date = date1; date <= date2; date = date.AddMonths(1)) {
                if (date.DayOfWeek == DayOfWeek.Sunday) {
                    sundays += 1;
                }
            }

            Console.WriteLine(sundays);
        }
    }
}
