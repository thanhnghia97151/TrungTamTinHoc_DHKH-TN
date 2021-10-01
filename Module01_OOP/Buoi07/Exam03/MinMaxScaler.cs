using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03
{
    class MinMaxScaler
    {
        double min, max;
        public double Min => min;
        public double Max => max;
        static double FindMin(double[] a)
        {
            double m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (m > a[i])
                {
                    m = a[i];
                }
            }
            return m;
                
        }
        static double FindMax(double[] a)
        {
            double m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (m < a[i])
                {
                    m = a[i];
                }
            }
            return m;

        }

        static (double , double) FindMinMax(double[] a)
        {
            double min = a[0], max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return (min, max);
        }
        public void Fit(double[] x)
        {
            (min, max) = FindMinMax(x);
        }

        public double[] Transfrom(double[] b)
        {
            double[] y = new double[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                y[i] = (b[i] - min) / (max - min);
            }
            return y;
        }

        public double[] FitTrnasform(double[] b)
        {
            (min, max) = FindMinMax(b);
            return Transfrom(b);
        }
    }
}
