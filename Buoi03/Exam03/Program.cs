using System;

namespace Exam03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen bat ky: ");
            int n = int.Parse(Console.ReadLine());
            if (n%2==0)
            {
                Console.WriteLine("So chan ");
            }
            else Console.WriteLine("So le ");
        }
    }
}
