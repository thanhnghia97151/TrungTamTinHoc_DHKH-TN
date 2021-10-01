using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show ket qua");
            Square square = new Square(3);
            Console.WriteLine($"Area: {square.Area}, Perimeter: {square.Perimeter}");

            Rectangle rectangle = new Rectangle(3,4);
            Console.WriteLine($"Area: {rectangle.Area}, Perimeter: {rectangle.Perimeter}");
        }
    }
}
