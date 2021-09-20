using System;

namespace Exam09
{
    class Program
    {
        static int LuyThua(int x, int n)
        {
            int s=1;
            for (int i=1; i<= n; i++)
            {
                s = s * x;
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Tong x^n: {LuyThua(x, n)}");
        }
    }
}
