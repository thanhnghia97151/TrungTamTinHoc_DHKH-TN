using System;

namespace Exam07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input: nhập vào giờ phút giây
            //Output: tăng thêm một giây
            Console.Write("Nhap gio: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            int s = int.Parse(Console.ReadLine());
            int ts = (s + 1) % 60;
            int tm = (m + (s + 1) / 60) % 60;
            int th = (h + (m + (s + 1) / 60) /60 ) % 24;

            Console.WriteLine($"{th}:{tm}:{ts}");

        }
    }
}
