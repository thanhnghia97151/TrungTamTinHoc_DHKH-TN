using System;

namespace Exam10
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a lon hon b");
            }
            else Console.WriteLine("b lon hon a");
        }
    }
}
