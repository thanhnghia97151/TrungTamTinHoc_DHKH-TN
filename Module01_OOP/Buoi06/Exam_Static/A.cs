using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Static
{
    class A
    {
        //Fields
        //Static

        static int a = 0;
        //non static
        int b = 0;
        public static int T 
        { 
            get
            {
                return a;
            } }
        public A()
        {
            a++;
            b++;
            Console.WriteLine($"a={a} b={b}");

            
        }
    }
}
