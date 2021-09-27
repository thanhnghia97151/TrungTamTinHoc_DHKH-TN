using System;

namespace Exam02_Struct
{
    class Program
    {
        struct Employee
        {
            //fields(private (default), public,protected, internal)

            //-private không thể truy cập từ bên ngoài

            int id;
            private string fullname;
            public string email;
            
            internal string a;
            //properties (public,internal)
            public int ID {get
                { return id; }
                set
                {
                    id = value;
                } }

            public string Fullname
            {
                get
                {
                    return  fullname;
                }
            }
            public decimal Salary
            {
                set
                {

                }
            }
            //auto properties
            //methods (private, internal, public)
            public void Nhap()
            {

            }
            //static
        }
        static void Main(string[] args)
        {
            //
        }
    }
}
