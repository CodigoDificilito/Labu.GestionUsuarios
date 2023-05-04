using Application.Interfaces.IRecruiter;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class RecruiterQuery:IRecruiterQuery
    {
        private readonly AppDbContext _context;
        public RecruiterQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Recruiter>> GetListaRecruiters()
        {
            var recruiters = await _context.Recruiter.ToListAsync();
            return recruiters;
        }

        public async Task<Recruiter> GetRecruiterById(int recruiterId)
        {
            var recruiter = await _context.Recruiter.FindAsync(recruiterId);
            return recruiter;
        }
    }
}
