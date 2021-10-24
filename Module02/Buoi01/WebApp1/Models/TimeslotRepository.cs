using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Controllers;

namespace WebApp1.Models
{
    public class TimeslotRepository : BaseRepository
    {
        //CSContext context;
        //public TimeslotRepository(CSContext context) 
        //{
        //    this.context = context;

        //}
        public TimeslotRepository(CSContext context) : base(context) { 
        
        }
        public List<Timeslot> GetTimeslot()
        {
            return context.Timeslots.ToList();
        }
        public int Add(Timeslot obj)
        {
            context.Timeslots.Add(obj);
            return context.SaveChanges();
        }
         public Timeslot GetTimeslotById(int id)
        {
            return context.Timeslots.Find(id);
        }
        public int Edit(Timeslot obj)
        {
            context.Timeslots.Update(obj);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            context.Timeslots.Remove(new Timeslot { Id = id });
            return context.SaveChanges();
        }
    }
}
