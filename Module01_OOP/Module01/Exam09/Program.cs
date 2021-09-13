using System;

namespace Exam09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiểu dữ liệu Data type
            //Integer
            byte a = 7; //1 byte
            sbyte sa = -7;
            short b = 5; //2 byte
            int c = 8; //4 byte
            ushort ub = 88;// không lấy phần âm
            uint ut = 33;// không lấy dấu

            //Float
            float d = 7.3f;
            double e = 7.9;
            decimal k = 7.8m;
            //String
            string s = "xin chao";
            char ct = 'a';
            //Bool
            bool x1 = true;
            bool x2 = false;
            // var
            //Ref cùng tham chiếu tới lẫn nhau
            int f = 7;
            ref int et = ref f;
            et = 99;
            // object và var 
            var tt = 8;
            var ttb = 8;
            Console.WriteLine(a + b);
            object ii = 7;
            object oo = 9;
            Console.WriteLine((int)ii +(int)oo);
            // khuyết điểm var không để khai báo hàm đc

        }
    }
}
