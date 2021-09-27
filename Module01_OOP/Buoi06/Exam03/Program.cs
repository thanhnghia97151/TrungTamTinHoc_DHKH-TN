using System;

namespace Exam03
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.DoSomeThing();
            a.DoThat();

            B b = new B();
            b.DoSomeThing();
            b.DoThat();

            A a1 = new B();
            a1.DoSomeThing();// In ra B do some thing vì có virtual (Đa xạ) Polymorphism
            a1.DoThat();// In ra Do that

            // B b = new A() ---> error
        }
    }
}
