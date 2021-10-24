using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class ProfressorRepository:BaseRepository
    {
        public ProfressorRepository(CSContext context) : base(context)
        {

        }
        public List<Professor> GetProfessor()
        {
            return context.Profressors.ToList();
        }
        public int Add(Professor professor)
        {
            context.Profressors.Add(professor);
            return context.SaveChanges();
        }
    }
}
