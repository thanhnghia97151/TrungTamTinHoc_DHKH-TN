using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    //Tupple
   


    class MinMaxRegression
    {

        static (int, int) MinMax(double[] x)
        {
            int iMin = 0, iMax = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[iMin] > x[i])
                {
                    iMin = i;
                }
                if (x[iMax] < x[i])
                {
                    iMax = i;
                }
            }
            return (iMin, iMax);
        }
    }
}
