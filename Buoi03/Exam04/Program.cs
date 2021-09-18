using System;

namespace Exam04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array 1D
            //Array 2D
            //matrix
            int[,] a =
            {
                {3,4,5 },
                {8,2,2 },
                {7,9,1 },
                {2,5,3 }

            };
            Console.WriteLine($"Rows: {a.GetLength(0)}");
            Console.WriteLine($"Columns: {a.GetLength(1)}");
            Console.WriteLine($"Element: {a.Length}");


        }
    }
}
