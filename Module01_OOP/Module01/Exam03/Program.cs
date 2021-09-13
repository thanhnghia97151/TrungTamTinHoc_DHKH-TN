using System;

namespace Exam03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int  b= int.Parse(Console.ReadLine());
            Console.WriteLine("Tong hai so: "+ (a+b));// đúng
            Console.WriteLine("Tong hai so: " + a + b);// đây là cộng chuỗi
        }
    }
}
