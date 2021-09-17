using System;

namespace Exam13
{
    class Program
    {
        static void Nam(int x)
        {
            if ((x % 400 == 0) || (x % 4 == 0 && x % 100 != 0))
            {
                Console.WriteLine($"{x} la nam nhuan");
            }
            else Console.WriteLine($"{x} la nam khong nhuan");
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Nam(r.Next(1, 2021));
        }
        static void SS(int x)
        {
            if (DateTime.IsLeapYear(x))
            {
                Console.WriteLine($"{x} la nam nhuan");
            }
            else Console.WriteLine($"{x} la nam khong nhuan");
        }
    }
}
