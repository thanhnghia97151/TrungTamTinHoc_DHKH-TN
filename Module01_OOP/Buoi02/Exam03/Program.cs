using System;

namespace Exam03
{
    class Program
    {
        // function, phải có từ khóa static trong function
        static int Tong(int a, int b)
        {
            int c = a + b;
            return c;
        }
        static void DoSomething()
        {
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}+{b}={a + b}");
        }
        static void Main(string[] args)
        {
            //Call Method
            Console.WriteLine(Tong(8, 7));

            int x = 7;
            int y = 8;
            int z = Tong(x, y);
            Console.WriteLine(z);

            Console.WriteLine(Tong(a: 27, b: 33));
            Console.WriteLine(Tong(b:33,a:27));

            DoSomething();
        }
    }
}
