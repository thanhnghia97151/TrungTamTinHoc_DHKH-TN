using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class ProfessorChecked
    {
        [Column("Professor_Id")]
        public int Id { get; set; }
        [Column("Professor_Name")]
        public string FullName { get; set; }
        public bool Checked { get; set; }
    }
}
