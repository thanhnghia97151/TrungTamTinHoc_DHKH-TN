using System;

namespace Exam06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random => số ngẫu nhiên
            Random rand = new Random();
            Console.WriteLine(rand.Next(3, 7));

            var a = new Random();
            Console.WriteLine(rand.Next(8, 100));

            object o = new Random();
            Console.WriteLine(((Random)o).Next(3, 7));

            //data type runtime
            dynamic d = new Random();
            Console.WriteLine(d.Next(6, 7));// khi chạy lên nó mới hiểu cái kiểu, nó không có suggest
        }
    }
}
