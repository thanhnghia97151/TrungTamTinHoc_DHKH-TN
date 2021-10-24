using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class OneHotEncoder : Encoder<int[,]>
    {
        //fields
        //Dictionary<string, int> dict;
        //List<string> reverse;
         
        //public void Fit(string[] input)
        //{
        //    dict = new Dictionary<string, int>();
        //    int c = 0;
        //    reverse = new List<string>(); 
        //    foreach (string v in input)
        //    {
        //        if (!dict.ContainsKey(v))
        //        {
        //            dict[v] = c;
        //            reverse.Add(v);
        //            c++;
        //        }
        //    }
        //}
        public override int[,] Transform(string[] input)
        {
            int[,] a = new int[input.Length, dict.Count];
            for (int i = 0; i < input.Length; i++)
            {
                a[i, dict[input[i]]] = 1;
            }
            return a;
        }
        //public int[,] FitTransform(string[] input)
        //{
        //    Fit(input);
        //    return Transform(input);
        //}
        public string[] Reverse(int[,] arr)
        {
            string[] brr = new string[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j]!=0)
                    {
                        brr[i] = reverse[j];
                    }
                }
            }
            return brr;
        }
    }
}
