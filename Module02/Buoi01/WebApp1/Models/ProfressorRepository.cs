using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


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
        public List<Professor> GetProfessorsByMoudleId(int id)
        {
            return context.Profressors.FromSqlRaw("Exec GetProfessorsByMoudleId @Id", new SqlParameter("@Id", id)).ToList();
        }
        public List<Professor> GetProfessorsNotInModule(int id)
        {
            return context.Profressors.FromSqlRaw("exec GetProfessorsNotInMoudle @Id", new SqlParameter("@Id", id)).ToList();
        }
        public int Add(Professor professor)
        {
            context.Profressors.Add(professor);
            return context.SaveChanges();
        }

        public List<ProfessorChecked> GetProfessorCheckeds(int id)
        {
            return context.professorCheckeds.FromSqlRaw("exec GetProfessorsChecked @Id", new SqlParameter("@Id", id)).ToList();
        }
    }
}
