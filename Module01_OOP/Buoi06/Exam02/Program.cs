using System;

namespace Exam02
{
    class Program
    {
        static void Main(string[] args)
        {

            //OOP (Ke thua, Đa xạ)
            Person p1 = new Person("Thanh Nghia");
            p1.DoSomeThing();

            Employ e1 = new Employ("ABC", 200000000000);
            e1.DoSomeThing();
            e1.DoThat();
            

            //Kế thừa, vitual + overide (đa xạ), new (ít dùng)

        }
    }
}
