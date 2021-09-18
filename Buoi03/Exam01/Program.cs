using System;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cho biet hom nay la ngay thu may: ");
            int today = int.Parse(Console.ReadLine());
            Console.Write("Nhap k (k>0): ");
            uint k = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Sau {k} ngay la thu may: { (today -1 + k)%7+1}");

        }
    }
}
