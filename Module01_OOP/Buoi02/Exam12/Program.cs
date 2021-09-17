using System;

namespace Exam12
{
    class Program
    {
        static void Chia(int x)
        {
            if (x % 3 == 0)
            {
                Console.WriteLine("Chia het cho 3");
            }
            else Console.WriteLine("khng chia het cho 3");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Chia(x);
        }
    }
}
