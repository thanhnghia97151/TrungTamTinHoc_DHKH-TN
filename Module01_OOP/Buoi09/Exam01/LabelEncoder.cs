using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class LabelEncoder:Encoder<int[]>
    {
        //Dictionary<string, int> dict;
        //string[] reverse;
        //public void Fit(string[] input)
        //{
        //    reverse = new string[input.Length];
        //    List<string> list = new List<string>();
        //    int c = 0;
        //    foreach (string v in input)
        //    {
        //        if (dict.ContainsKey(v))
        //        {
        //            dict[v] = c++;
        //            list.Add(v);
        //        }
        //    }
        //    reverse = list.ToArray();
        //}
        public override int[] Transform(string[] input)
        {
            int[] a = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                a[i] = dict[input[i]];
            }
            return a;
        }
        //public int[] FitTransform(string[] input)
        //{
        //    Fit(input);
        //    return Transform(input);
        //}
        public string[] Reverse(int[] input)
        {
            string[] resulf = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                resulf[i] = reverse[input[i]];
            }
            return resulf;
        }
    }
}
