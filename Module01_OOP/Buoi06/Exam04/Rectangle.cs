using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class Rectangle
    {
        double a, b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Area()
        {
            return a * b;
        }
        public double Perimeter()
        {
            return 2 * (a + b);
        }
    }
}
