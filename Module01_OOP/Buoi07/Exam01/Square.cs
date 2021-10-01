using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class Square
    {
        //protected đễ lớp con mới thấy đc
        protected double a;
        public Square(double a)
        {
            this.a = a;
        }
        public virtual double Area => a * a;
        public virtual double Perimeter => 4 * a;
        //{
        //get......
        //set
        //}
    }
}
