using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class Re_Retangle : Shape
    {
        double a, b;
        public Re_Retangle(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        //public override double Area => a*b;

        public override double Area
        {
            get
            {
                return a * b;
            }
        }
        public override double Perimeter => (a+b)*2;
    }
    
}
