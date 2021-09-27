using System;

namespace Exam_Const_ReadOnly
{
    class Program
    {
        // Const gần giống static
        const int A = 3;
        readonly int x = 3;
        public Program(int x)
        {
            this.x = x; //dùng constructor để thay đổi
        }

        //Constructor static -> thay đổi gt cho static readonly
        static readonly int y = 88;
        static Program()
        {
            y = 9989;
        }
        static void Main(string[] args)
        {
           // Program p = new Program();// Khai báo Program mới gọi được biến non - static
            //Console.WriteLine(p.x);
        }
    }
}
