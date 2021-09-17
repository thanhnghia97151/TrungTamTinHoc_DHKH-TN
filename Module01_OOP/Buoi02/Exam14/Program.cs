using System;

namespace Exam14
{
    class Program
    {
        static void SoNgay(int y, int m)
        {
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                {
                    Console.WriteLine($"Thang {m} nam {y} co 31 ngay");
                }
                else if (m == 2)
                {
                    Console.WriteLine($"Thang {m} nam {y} co 29 ngay");
                }
                else Console.WriteLine($"Thang {m} nam {y} co 30 ngay");
            }
            else
            {
                if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                {
                    Console.WriteLine($"Thang {m} nam {y} co 31 ngay");
                }
                else if (m == 2)
                {
                    Console.WriteLine($"Thang {m} nam {y} co 28 ngay");
                }
                else Console.WriteLine($"Thang {m} nam {y} co 30 ngay");
            }
        }
        static void Main(string[] args)
        {
            Random y = new Random();

            Random m = new Random();

            SoNgay(y.Next(1, 2021), m.Next(1, 12));
        }
    }
}
