using System;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "red", "blue", "green", "yellow", "red", "green" };
            OneHotEncoder oneHotEncoder = new OneHotEncoder();
            int[,] output = oneHotEncoder.FitTransform(input);
            for (int i = 0; i < output.GetLength(0); i++)
            {
                for (int j = 0; j < output.GetLength(1); j++)
                {
                    Console.Write($"{output[i, j]}");
                }
                Console.WriteLine();
            }
            string[] result = oneHotEncoder.Reverse(output);
            Console.WriteLine(string.Join(',', result));
        }
    }
}
