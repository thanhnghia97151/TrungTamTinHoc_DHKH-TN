using System;

namespace Exam02
{
    class Program
    {
        static void Main(string[] args)
        {
            //var, object, dynamic
            var a = 3;
            var b = 7.3;

            //a = "xin chào"; lỗi
            // 1 kieu du lieu
            object c = 3;
            object d = 7;
            //Console.Write(c+d); error
            Console.WriteLine((int)c+(int)d);
            c = "xin chào";

            dynamic x = 3;
            dynamic y = 7;
            Console.Write(x + y);
            x = "xin chào";
        }
    }
}
