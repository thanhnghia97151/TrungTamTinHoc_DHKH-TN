using System;

namespace Exam06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            long s = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = s + i*i;
            }
            Console.WriteLine($"Tong 1^2 + 2^2 +.....+ n^2: {s}");
        }
    }
}
