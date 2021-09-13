using System;

namespace Exam10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap h: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap s: ");
            int s = int.Parse(Console.ReadLine());

            int ts = ((s + 60) - 1) % 60;
            int tm = 0;
        }
    }
}
