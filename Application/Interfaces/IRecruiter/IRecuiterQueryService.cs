using Application.DTO;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRecruiter
{
    public interface IRecuiterQueryService
    {
        public Task<ResponseMessage> GetRecruiterById(int recruiterId);
        public Task<List<RecruiterDTO>> GetRecruiterList();
    }
}
