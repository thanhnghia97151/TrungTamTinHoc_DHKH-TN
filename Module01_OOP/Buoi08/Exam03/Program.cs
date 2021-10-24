using System;
using System.Collections.Generic;

namespace Exam03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary,
            //Array,
            //Generic
            //Kế thừa
           
            
            //string[] input = { "red", "green", "red", "blue", "orange", "red" };
            
            //Cách 1
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //int c = 0;
            //foreach (string v in input)
            //{
            //    if (!dict.ContainsKey(v))
            //    {
            //        dict[v] = c++;

            //    }
            //}
            //foreach (KeyValuePair<string,int> item in dict)
            //{
            //    Console.WriteLine($"key: {item.Key}, value: {item.Value}");

            //}
            //int[] output = new int[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{

            //}

            //Cách 2 
            string[] input = { "red", "green", "red", "blue", "orange", "red" };
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int c = 0;
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string k = input[i];
                if (!dict.ContainsKey(k))
                {
                    dict[k] = c++;
                }
                output[i] = dict[k];
            }
            Console.WriteLine(string.Join(",", output));
        }
       
    }
}
