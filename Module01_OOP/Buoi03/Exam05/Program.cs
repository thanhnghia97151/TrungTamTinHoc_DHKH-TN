using System;

namespace Exam05
{
    class Program
    {
        static string  Test(int com, int hum)
        {
            string[,] a =
                {
                {"Hoa","Thang","Thua" },
                {"Thua","Hoa","Thang" },
                {"Thang","Thua","Hoa" }

            };
            return a[com, hum];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("0: bao");
            Console.WriteLine("1: bua");
            Console.WriteLine("2: keo");
            Random may = new Random();
             Console.Write("Moi ban chon: ");
            int n = int.Parse(Console.ReadLine());
            int k = may.Next(3);
            Console.WriteLine($"Moi ban chon: {k}");
            Console.WriteLine( Test(k, n));
        }
    }
}
