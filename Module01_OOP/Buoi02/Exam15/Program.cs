using System;

namespace Exam15
{
    class Program
    {
        static bool KiemTraSoChinhPhuong(int x)
        {
            int t = (int)Math.Sqrt(x);
            return x == t*t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            if (KiemTraSoChinhPhuong(x))
            {
                Console.WriteLine($"{x} la so chinh phuong");
            }
            else Console.WriteLine($"{x} la so chinh phuong");
        }
    }
}
