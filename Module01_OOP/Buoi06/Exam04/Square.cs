using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class Square
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }
        public double Area()
        {
            return a * a;
        }
        public double Perimeter()
        {
            return a * 4;
        }
    }
}
