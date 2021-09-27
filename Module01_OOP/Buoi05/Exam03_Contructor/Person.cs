using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03_Contructor
{
    struct Person
    {
        //constructor method
        //Tên phương thức == tên struct
        //Ko có giá trị trả về
        //Tự động đươc gọi khi khởi tạo (Ko thề dùng đối tượng gọi phương thức)
        string fullname;
        int id;
        public Person(int id, string fullname)
        {
            this.id = id;
            this.fullname = fullname;
            Console.WriteLine("Auto call");
        }
        public void DoSomeThing()
        {
            Console.WriteLine("Xin chào");
        }
    }
}
