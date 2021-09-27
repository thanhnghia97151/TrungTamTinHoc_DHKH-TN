using System;

namespace Exam03_Contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person t1 = new Person(1, "nghia");
            Person t2 = new Person(fullname: "Nghiax", id: 1);
            t1.DoSomeThing();
            t2.DoSomeThing();

            Student s1 = new Student();
            s1.Id = 7;
            s1.Fullname = "hang";
            //s1.Gender = true;//error
            s1.Email = "abc@gamil.com";

            Student s2 = new Student()
            {
                Id = 77,
                Email = "Nguyenthanhnghia",
                Fullname = "Nghiax"
            };
        }
    }
}
