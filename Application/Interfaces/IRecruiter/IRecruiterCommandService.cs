using Application.DTO.Request;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRecruiter
{
    public interface IRecruiterCommandService
    {
        public Task<ResponseMessage> CreateRecruiter(CreateRecruiterRequest request);
    }
}
