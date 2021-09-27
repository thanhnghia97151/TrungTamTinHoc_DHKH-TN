using System;

namespace Exam_Struct_Class
{
    class Program
    {
        class Cat
        {
            public string name;
            public override string ToString()
            {
                return name;
            }
        }
        struct Dog
        {

            public string name;
            public override string ToString()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
