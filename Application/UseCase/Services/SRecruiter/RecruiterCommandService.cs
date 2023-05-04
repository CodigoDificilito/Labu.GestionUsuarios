using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces.IRecruiter;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SRecruiter
{
    public class RecruiterCommandService:IRecruiterCommandService
    {
        private readonly IRecruiterCommand _command;


        public RecruiterCommandService(IRecruiterCommand command)
        {
            _command = command;
        }

        public async Task<ResponseMessage> CreateRecruiter(CreateRecruiterRequest request)
        {
            var recruiter = new Recruiter
            {
                EmpresaId = request.EmpresaId,
                PersonaId = request.PersonaId,
            };
            await _command.CreateRecruiter(recruiter);
            var result = new CreateRecruiterResponse
            {
                EmpresaId = request.EmpresaId,
                PersonaId = request.PersonaId,
            };
            return new ResponseMessage(201, result);

        }
    }
}
