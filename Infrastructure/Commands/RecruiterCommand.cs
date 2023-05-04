using Application.Interfaces.IRecruiter;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class RecruiterCommand:IRecruiterCommand
    {
        private readonly AppDbContext _context;

        public RecruiterCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateRecruiter(Recruiter recruiter)
        {
            _context.Add(recruiter);
            await _context.SaveChangesAsync();
        }
    }
}
