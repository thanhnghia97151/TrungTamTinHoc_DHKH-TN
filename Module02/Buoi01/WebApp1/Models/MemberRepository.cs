using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.ViewModels;
using WebApp1.Helper;

namespace WebApp1.Models
{
    public class MemberRepository : BaseRepository
    {
        public MemberRepository(CSContext context) : base(context)
        {

        }
        public List<Member> GetMembers()
        {
            return context.Members.ToList();
        }
        public int Add(Member obj)
        {
            context.Members.Add(obj);
            return context.SaveChanges();
        }
        public Member Login(LoginModel obj)
        {
            return context.Members.Where(p => (p.Username == obj.Username ||
              p.Email == obj.Username) && p.Password == Helper.Helper.Hash(obj.Password)).FirstOrDefault();
        }
    }
}
