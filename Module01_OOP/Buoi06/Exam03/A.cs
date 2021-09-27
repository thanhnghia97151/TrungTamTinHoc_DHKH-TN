using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03
{
    class A
    {
        // Method 
        //Method Virtual
        public virtual void DoSomeThing()
        {
            Console.WriteLine("A Do Something");
        }
        //Method non- virtual
        public void DoThat()
        {
            Console.WriteLine("Do that");
        }
    }
}
