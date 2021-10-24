using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class CountVectorizer : ICountVectorizer
    {
        Dictionary<string, int> dict;
        char[] seperator = { ' ', ',', '.', '?' };
        public string[] Featurenames //=> throw new NotImplementedException();
        {
            get
            {
                return new List<string>(dict.Keys).ToArray(); 
            }
        }
        public void Fit(string[] courpus)
        {
            dict = new Dictionary<string, int>();
            int c = 0;
            foreach (string line in courpus)
            {
                string[] words = line.Split(seperator);
                foreach (string w in words)
                {
                    if (!string.IsNullOrEmpty(w))
                    {
                        string k = w.Trim().ToLower();
                        dict[k] = c++;
                    }
                }
            }
        }

        public int[,] FitTransform(string[] courpus)
        {
            Fit(courpus);
            return Transform(courpus);
        }

        public int[,] Transform(string[] courpus)
        {
            int[,] matrix = new int[courpus.Length, dict.Count];
            for (int i = 0; i < courpus.Length; i++)
            {
                string[] words = courpus[i].Split(seperator);
                for (int j = 0; j < words.Length; j++)
                {
                    string w = words[j];
                    if (!string.IsNullOrEmpty(w))
                    {
                        string k = w.ToLower();
                        matrix[i, dict[k]]++;
                    }
                }
            }
            return matrix;
        }
    }
}
