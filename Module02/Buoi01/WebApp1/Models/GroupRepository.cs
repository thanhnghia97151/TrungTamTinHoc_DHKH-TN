using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class GroupRepository : BaseRepository
    {
       
        public GroupRepository(CSContext context) : base(context)
        {
            
        }
        
        public List<Group> GetGroups()
        {
            return context.Groups.ToList();
        }
        public int Add(List<Group> list)
        {
            context.Groups.AddRange(list);
            return context.SaveChanges();
        }
    }
}
