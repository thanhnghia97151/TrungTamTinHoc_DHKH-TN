using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    [Table("Timeslot")]
    public class Timeslot
    {
        [Column("TimeslotId"),Required(ErrorMessage ="Nhập vào bạn nhé")]
        public int Id { get; set; }   
        [Required(ErrorMessage = "Nhập vào Weekday")]
        public string Weekday { get; set; }
        [Column("StartTime"),Required]
        public DateTime Start { get; set; }
        [Column("EndTime"),Required]
        public DateTime End { get; set; }
    }
}
