using System;
using System.Collections.Generic;

namespace Exam02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "red", "blue", "green", "yellow", "red", "green" };
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            foreach (string v in input)
            {
                if (!dict.ContainsKey(v))
                {
                    dict[v] = 0;
                }

            }
            List<string> keys = new List<string>(dict.Keys);
            int c = 0;
            foreach (string item in keys)
            {
                dict[item] = c++;
            }
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = dict[input[i]];
            }        
            Console.WriteLine(string.Join(',', output));
        }
    }
}
