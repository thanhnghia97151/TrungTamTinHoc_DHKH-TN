using System;

namespace Exam08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so tien can doi: ");
            // Đổi tiền
            int m = int.Parse(Console.ReadLine());
            int to50 = m / 50;
            int r = m % 50;
            int to20 = r / 20;
            r = r % 20;
            int to10 = r / 10;
            r = r % 10;
            int to5 = r / 5;
            r = r % 5;
            int to2 = r / 2;
            r = r % 2;
            int to1 = r;
            Console.WriteLine($"{to50}to 50,{to20} to 20,{to10} to 10,{to5} to 5,{to2} to 2,{to1} to 1");
        }
    }
}
