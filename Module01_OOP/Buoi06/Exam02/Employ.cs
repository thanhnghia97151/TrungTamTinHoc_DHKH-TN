using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    class Employ : Person
    {
        decimal salary;
        public Employ(String fullname, decimal salary) : base(fullname) // dùng bass dể gọi fullname
        {
            this.salary = salary;
        }
        public void DoThat()
        {
            Console.WriteLine("Employ");
        }
    }
}
