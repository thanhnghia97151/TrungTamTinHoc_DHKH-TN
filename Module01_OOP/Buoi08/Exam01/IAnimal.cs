using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    interface IAnimal
    {
        
        public void DoSomeThing()
        {
            Console.WriteLine("IAnimal Do SomeThing");
            //Interface là phương thức trừu tượng (ko cần dùng abstract)
            
        }
        void Go();
    }
}
