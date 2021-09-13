using System;

namespace Exam04
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.WriteLine("Nhap vao ban kinh hinh tron:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Chu vi hinh tron:   {(2 * PI * r)}");
            Console.WriteLine("Dien tich hinh tron: " + (Math.PI * r*r));
        }
    }
}
