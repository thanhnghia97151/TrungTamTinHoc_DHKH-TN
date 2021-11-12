using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class RoleRepository :BaseRepository
    {
        public RoleRepository(CSContext context) :base(context) { }
        public int Add(Role role)
        {
            context.Roles.Add(role);
            return context.SaveChanges();
        }
        public List<Role> GetRoles()
        {
            return context.Roles.ToList();
        }
        public List<RoleChecked> GetRoleCheckeds(string id)
        {
            return context.RoleCheckeds.FromSqlRaw("exec GetRolesByMember @Id", new SqlParameter("@Id", id)).ToList();
        }
        public List<Role> GetRolesByMemberId(string id)
        {
            return context.Roles.FromSqlRaw("exec GetRolesByMemberId @Id", new SqlParameter("@Id", id)).ToList();
        }

    }
}
