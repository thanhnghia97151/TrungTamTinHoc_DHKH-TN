using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    
    public class RoomRepository
    {
        CSContext context;
        public RoomRepository(CSContext context)
        {
            this.context = context;
        }
        public List<Room> GetRooms()
        {
            return context.Rooms.ToList();
        }
        public int Add(Room obj)
        {
            context.Rooms.Add(obj);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            context.Rooms.Remove(new Room { Id = id });
            return context.SaveChanges();
        }
        public Room GetRoomByID(int id)
        {
            return context.Rooms.Find(id);
        }
        public int Edit(Room obj)
        {
            context.Rooms.Update(obj);
            return context.SaveChanges();
        }
    }
}
