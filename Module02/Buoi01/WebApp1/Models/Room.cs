using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    [Table("Room")]
    public class Room
    {
        [Column("RoomId")]
        public int Id { get; set; }
        [Column("RoomNumber")]
        public string Number { get; set; }
        public short Capacity { get; set; }
    }
}
