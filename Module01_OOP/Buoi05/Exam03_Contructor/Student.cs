using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03_Contructor
{
    struct Student
    {
        //fields
        //properties
        public int Id { get; set; }
        public string  Fullname { get; set; }
        public string Email { private get; set; }//bên ngoia2 chỉ set không get
        public bool Gender { get; private set; }
    }
}
