using System;

namespace Exam04
{
    class Program
    {
        //Ham co gia tri mac dinh
        static int Tong(int a, int b)
        {
            return a + b;
        }
        static int Tong(int a, int b, int c)
        {
            return a + b + c;

        }
        static int Sum(int a, int b, int c = 0)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Tong(3,7));
            Console.WriteLine(Tong(3, 7, 9));

            Console.WriteLine(Sum(3, 7));
            Console.WriteLine(Sum(3, 7, 9));


        }
    }
}
