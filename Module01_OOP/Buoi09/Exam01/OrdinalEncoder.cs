using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class OrdinalEncoder:LabelEncoder
    {
        public override void Fit(string[] input)
        {
            dict = new SortedDictionary<string, int>();
            foreach (string v in input)
            {
                if (!dict.ContainsKey(v))
                {
                    dict[v] = 0;
                }
            }
            List<string> keys = new List<string>(dict.Keys);
            int c = 0;
            foreach (string k in keys)
            {
                dict[k] = c++;
            }
            reverse = keys.ToArray();
        }
        //SortedDictionary<string, int> dict;
        //string[] reverse;
        //public void Fit(string[] input)
        //{
        //    dict = new SortedDictionary<string, int>();
        //    foreach (string v in input)
        //    {
        //        if (!dict.ContainsKey(v))
        //        {
        //            dict[v] = 0;
        //        }
        //    }
        //    List<string> keys = new List<string>(dict.Keys);
        //    int c = 0;
        //    foreach (string k in keys)
        //    {
        //        dict[k] = c++;
        //    }
        //    reverse = keys.ToArray();

        //}
        //public int[] Transform(string[] input)
        //{
        //    int[] arr = new int[input.Length];
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        arr[i] = dict[input[i]];
        //    }
        //    return arr;
        //}
        //public int[] FitTransform(string[] input)
        //{
        //    Fit(input);
        //    return Transform(input);
        //}
    }
}
