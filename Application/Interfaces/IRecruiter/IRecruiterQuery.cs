using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRecruiter
{
    public interface IRecruiterQuery
    {
        public Task<Recruiter> GetRecruiterById(int recruiterId);
        public Task<List<Recruiter>> GetListaRecruiters();
    }
}
