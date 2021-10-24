using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    [Table("Module")]
    public class Module
    {
        [Column("ModuleId")]
        public int Id { get; set; }
        [Column("ModuleCode")]
        public string Code { get; set; }
        [Column("ModuleName")]
        public string Name { get; set; }
    }
}
