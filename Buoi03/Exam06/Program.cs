using System;
using System.Collections.Generic;

namespace Exam06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary (Key) => int, string, float, char
            //
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "One" ,1},
                { "Two" ,2},
                { "Three" ,3},
                { "Four" ,4}

            };

            string k = Console.ReadLine();
            if (dict.ContainsKey(k))
            {
                Console.WriteLine(dict[k]);
            }
            else
            {
                Console.WriteLine("NOt found");
            }
            Dictionary<char, float> d = new Dictionary<char, float>();
            d['a'] = 5.6f;
            d['b'] = 0.6f;

        }
    }
}
