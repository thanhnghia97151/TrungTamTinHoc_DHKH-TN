using System;


namespace Exam_Test
{
    class Program
    {
        static int Tong(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            User user = new User() { Id = 1, Name = "dfadf", Password = "akdfjlakdf" };
            Console.WriteLine($"{Tong(2, 3)}");
        }
    }
}
