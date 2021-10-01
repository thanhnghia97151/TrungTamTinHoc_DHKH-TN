using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class Retangle : Square
    {
        double b;
        public Retangle(double a, double b) : base(a)
        {
            this.b = b;
        }
        public override double Area => a*b;
        public override double Perimeter => 2 *(a+b);
    }
}
