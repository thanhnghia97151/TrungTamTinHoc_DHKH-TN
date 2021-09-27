using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class Ellipse
    {
        double a, b;
        public Ellipse(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Area()
        {
            return Math.PI * a * b;
        }
        public double Perimeter()
        {
            return Math.PI * (a + b);
        }
    }
}
