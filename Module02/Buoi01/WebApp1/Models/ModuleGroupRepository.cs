using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApp1.Models
{
    public class ModuleGroupRepository : BaseRepository
    {
        public ModuleGroupRepository(CSContext context):base(context)
        {

        }
        public List<ModuleGroup> GetModuleGroups()
        {
            return context.ModuleGroups.Include(p => p.Module).Include(p => p.Group).ToList();
        }
        public int Add(string path)
        {

            return context.Database.ExecuteSqlRaw($"bulk insert ModuleGroup from '{path}' with (FORMAT='csv',firstrow =2,Fieldterminator=',',rowterminator='0x0A')");
        }
        public int Add(List<ModuleGroup> list)
        {
            context.ModuleGroups.AddRange(list);
            return context.SaveChanges();
        }
    }
}
