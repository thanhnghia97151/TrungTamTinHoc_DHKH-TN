using System;

namespace Exam08
{
    class Program
    {
        //Tham số đầu ra
        static void Foo(out int c)
        {

            c = 7;
        }
        // Vừa là đầu vào vừa đầu ra
        static void Goo(ref int a)
        {
            
        }
        static void Main(string[] args)
        {
            int b = 6;
            Goo(ref b);// phải gán giá trị

            //Không cần gàn giá trị
            int c;
            Foo(out c);
            Foo(out int d);
        }
    }
}
