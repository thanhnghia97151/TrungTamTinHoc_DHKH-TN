using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap vao mot goc");
            int angle = int.Parse(Console.ReadLine());
            Console.WriteLine($"Goc {angle} thuoc phan tu: {angle % 360 / 90 + 1}");
        }
    }
}
