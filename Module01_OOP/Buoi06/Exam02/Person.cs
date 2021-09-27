using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Person
    {
        string fullname;
        public Person(string fullname)
        {
            this.fullname = fullname;
        }
        public void DoSomeThing()
        {
            Console.WriteLine("Person do some thing");
        }
    }
}
