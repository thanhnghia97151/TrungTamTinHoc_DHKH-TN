using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class MemberInRoleRepository:BaseRepository
    {
        public MemberInRoleRepository(CSContext context): base(context) { }
        public int Add(MemberInRole obj)
        {
            SqlParameter[] parameters =
            {
                    new SqlParameter("@MemberId",obj.MemberId),
            new SqlParameter("@RoleId", obj.RoleId)
            };
            return context.Database.ExecuteSqlRaw("exec SaveMemberInRole @MemberId, @RoleId", parameters);
        }
    }
}
