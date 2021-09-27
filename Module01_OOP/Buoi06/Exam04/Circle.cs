using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class Circle
    {
        double r;
        public Circle(double r)
        {
            this.r = r;

        }
        public double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public double Perimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}
