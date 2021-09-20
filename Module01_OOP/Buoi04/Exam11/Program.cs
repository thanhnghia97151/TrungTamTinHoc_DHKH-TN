using System;

namespace Exam11
{
    class Program
    {
        static double TrunBinh(int[] a)
        {
            double s=0;
            foreach (var item in a)
            {
                s += item;
            }
            return s / a.Length;
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                a[i] = random.Next(1, 3);
            }
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Trung binh: {TrunBinh(a)}");
        }
    }
}
