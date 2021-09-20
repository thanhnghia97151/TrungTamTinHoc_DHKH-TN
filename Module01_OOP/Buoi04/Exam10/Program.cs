using System;

namespace Exam10
{
    class Program
    {
        static double Sum(int n)
        {
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                s = Math.Sqrt(2 + s);
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Tong: {Sum(n)}");
        }
    }
}
