using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRecruiter
{
    public interface IRecruiterCommand
    {
        public Task CreateRecruiter(Recruiter recruiter);
        
    }
}
