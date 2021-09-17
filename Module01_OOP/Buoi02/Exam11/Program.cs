using System;

namespace Exam11
{
    class Program
    {
        static void KiemTraChanLe(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("chan");
            }
            else Console.WriteLine("le");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 != 0)
            {
                Console.WriteLine("Le");
            }
            else Console.WriteLine("chan");
        }
    }
}
