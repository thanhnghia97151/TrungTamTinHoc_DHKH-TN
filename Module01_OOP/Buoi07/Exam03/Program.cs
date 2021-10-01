using System;

namespace Exam03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double[] input = { 1, 2, 4, 6, 7, 8, 0, 12, 45 };
            MinMaxScaler m = new MinMaxScaler();
            double[] output = m.FitTrnasform(input);
            Console.WriteLine($"Scaler: {string.Join(",",output)}");
        }
    }
}
