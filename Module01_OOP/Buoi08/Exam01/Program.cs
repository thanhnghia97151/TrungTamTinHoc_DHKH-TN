using System;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Giống abstract không thể khởi tạo
            IAnimal animal = new Cat();
            animal.DoSomeThing();

            //Hàm con trong Interface ko có tính kế thừa
            Cat cat = new Cat();
            // cat.
            cat.Go();
            //Interface là phương thức trừu tượng (ko cần dùng abstract)
        }
    }
}
