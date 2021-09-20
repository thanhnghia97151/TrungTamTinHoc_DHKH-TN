using System;

namespace Exam08
{
    class Program
    {
        static int Tich(int k)
        {
            int tich = 1;
            for (int i = 1; i <=k; i++)
            {
                tich = tich * i;
            }
            return tich;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int s=0;
            for (int i = 1; i <=n; i++)
            {
                s = s + Tich(i);
            }
            Console.WriteLine($"Tong 1+1*2+1*2*3+....+1: {s}");
        }
    }
}
