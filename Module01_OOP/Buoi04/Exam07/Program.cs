using System;

namespace Exam07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            double s = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = s + 1.0 / (i*2);
            }
            Console.WriteLine($"TOng 1/2+1/4+...+1/2n: {s}");
        }
    }
}
