using Application.DTO;
using Application.DTO.Response;
using Application.Interfaces.IRecruiter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SRecruiter
{
    public class RecruiterQueryService:IRecuiterQueryService
    {
        private readonly IRecruiterQuery _query;

        public RecruiterQueryService(IRecruiterQuery query)
        {
            _query = query;
        }

        public async Task<ResponseMessage> GetRecruiterById(int recruiterId)
        {
            var recruiter = await _query.GetRecruiterById(recruiterId);
            if (recruiter == null)
            {
                return new ResponseMessage(404, new { request = "Recruiter no encontrado" });
            }
            return new ResponseMessage(201, new RecruiterDTO()
            {
                EmpresaId= recruiter.EmpresaId,
                PersonaId= recruiter.PersonaId
            });
        }

        public async Task<List<RecruiterDTO>> GetRecruiterList()
        {
            var recruiters = await _query.GetListaRecruiters();
            var recruitersDTO = new List<RecruiterDTO>();

            foreach (var item in recruiters)
            {
                var recruiterDTO = new RecruiterDTO()
                {
                    EmpresaId= item.EmpresaId,
                    PersonaId= item.PersonaId
                };
                recruitersDTO.Add(recruiterDTO);
            }
            return recruitersDTO;
        }
    }
}
