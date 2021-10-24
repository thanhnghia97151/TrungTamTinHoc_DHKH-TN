using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public abstract class BaseRepository
    {
        protected CSContext context;
        public BaseRepository(CSContext context)
        {
            this.context = context;
        }
    }
}
