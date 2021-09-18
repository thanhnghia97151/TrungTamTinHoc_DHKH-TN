using System;

namespace Exam07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen bat ky :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap k: ");
            uint k = uint.Parse(Console.ReadLine());
            if (x%k == 0 )
            {
                Console.WriteLine($"{x} chia het cho {k}");
            }
            else
                Console.WriteLine($"{x} khong chia het cho {k}");
        }
    }
}
