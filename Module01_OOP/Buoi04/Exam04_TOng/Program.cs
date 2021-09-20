using System;

namespace Exam04_TOng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int s = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            Console.WriteLine($"Tong {s}");
        }
    }
}
