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

            Console.Write("Nhap k giay: ");
            int k = int.Parse(Console.ReadLine());

            int t = (h * 3600 + m * 60 + s - k % 86400 +86400)%86400;
            h = t / 3600;
            t = t % 3600;
            m = t / 60;
            t = t % 60;
            s = t / 60;

            Console.WriteLine($"{h}:{m}:{s}");

        }
    }
}
