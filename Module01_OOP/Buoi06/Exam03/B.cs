using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03
{
    class B : A
    {
        //overide, lớp cha phải có virtual mới sử dụng được overide
        public override void DoSomeThing()
        {
            Console.WriteLine("B Do something");
        }
        //new dành cho method ở lớp cha ko có virtual
        public new void DoThat()
        {
            Console.WriteLine("B do some thing");
        }
    }
}
