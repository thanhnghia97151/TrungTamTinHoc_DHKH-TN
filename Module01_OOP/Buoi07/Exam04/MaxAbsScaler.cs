using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class MaxAbsScaler
    {
        double maxAbs;
        //Tìm giá trị tuyệt đối lớn nhất
        static double FindMaxAbs(double[] a)
        {
            double max = Math.Abs(a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                if (max < Math.Abs(a[i]))
                {
                    max = Math.Abs(a[i]);
                }
            }
            return max;
        }
        public void Fit(double[] x)
        {
            maxAbs = FindMaxAbs(x);
        }
        public double[] Transform(double[] x)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = (x[i] / maxAbs);
            }
            return y;
        }
        public double[] Inverse(double[] x)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = (x[i] * maxAbs);
            }
            return y;
        }
    }

}
