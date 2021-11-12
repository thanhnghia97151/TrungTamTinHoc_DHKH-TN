using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class SiteProvider
    {
        CSContext context;
        public SiteProvider(CSContext context)
        {
            //Khuyết điểm
            //Tự động khởi tạo
            this.context = context;
        }
        //Fileds
        public RoleRepository role;
        //properties
        public RoleRepository Role
        {
            get
            {
                if (role is null)
                {
                    role = new RoleRepository(context);
                }
                return role;
                //return role ?? new RoleRepository(context);
            }
        }
    }
}
