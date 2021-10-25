using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    [Table("ModuleProfessor")]
    public class ModuleProfessor
    {
         [Column("ModuleId")]
        public int ModuleId { get; set; }
        [Column("ProfessorId")]
        public int ProfessorId { get; set; }

        //
        public Module Module { get; set; }
        public Professor Processor { get; set; }
    }
}
