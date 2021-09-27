using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class Triangle
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c));
        }
        public double Perimeter()
        {
            return a + b + c;
        }
    }
}
