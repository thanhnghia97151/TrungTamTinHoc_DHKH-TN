using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    [Table("Professor")]
    public class Professor
    {   
        [Column("Professor_Id")]
        public int Id { get; set; }
        [Column("Professor_Name")]
        public string FullName { get; set; }

        // Thêm prop để sử dụng mapping 
        public List<ModuleProfessor> ModuleProfessors { get; set; }
    }
}
