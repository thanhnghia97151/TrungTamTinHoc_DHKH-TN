using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    abstract class Encoder<T>
    {
        protected IDictionary<string, int> dict;//dùng interface
        protected string[] reverse;

        
        public virtual void Fit(string[] input)
        {
            reverse = new string[input.Length];
            List<string> list = new List<string>();
            int c = 0;
            foreach (string v in input)
            {
                if (dict.ContainsKey(v))
                {
                    dict[v] = c++;
                    list.Add(v);
                }
            }
            reverse = list.ToArray();
        }
        public T FitTransform(string[] input)
        {
            Fit(input);
            return Transform(input);
        }
        public abstract T Transform(string[] input);
    }
}
