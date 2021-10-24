using System;
using System.Collections.Generic;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courpus =
            {
                "This I Can't is the first document.",
                "This document is the second document.",
                "And this is the third one.",
                "Is this the first document?"
            };
            char[] separator = { ' ', ',','.','?' };
            int c = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var line in courpus)
            {
                string[] words = line.Split(separator);
                foreach (string w in words)
                {
                    if (!string.IsNullOrEmpty(w))
                    {
                        string k = w.ToLower();
                        if (!dict.ContainsKey(k))
                        {
                            dict[k] = c++;
                        }
                    }
                    
                }
            }
            foreach (KeyValuePair<string,int> item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            int[,] matrix = new int[courpus.Length,dict.Count];
            for (int i = 0; i < courpus.Length; i++)
            {
                string[] words = courpus[i].Split(separator);
                for (int j = 0; j < words.Length; j++)
                {
                    if (!string.IsNullOrEmpty(words[j]))
                    {
                        string k = words[j].ToLower();
                        matrix[i,dict[k]] += 1;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
