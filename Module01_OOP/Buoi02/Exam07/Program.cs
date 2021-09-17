using System;

namespace Exam07
{
    class Program
    {
        static void Foo(ref int a)
        {
            a = 77;
            Console.WriteLine($"a = {a}");
        }
        static void Main(string[] args)
        {
            //ref, out, ko dùng gì cả?
            int a = 7;
            int c = a;
            c = 99;
            Console.WriteLine(a);// Kết quả bằng 7
            Console.WriteLine(c);// Kết quả bằng 99


            ref int b = ref a;

            Foo(ref b);
            Console.WriteLine($"b={b}"); //b =77

            
        }
    }
}
