using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    [Table("ModuleGroup")]
    public class ModuleGroup
    {
        public int ModuleId { get; set; }
        public int GroupId { get; set; }

        //
        public Module Module { get; set; }
        public Group Group { get; set; }
    }
}
