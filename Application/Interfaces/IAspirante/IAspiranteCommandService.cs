using Application.DTO.Request;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IAspirante
{
    public interface IAspiranteCommandService
    {
        Task<ResponseMessage> CreateAspirante(CreateAspiranteRequest dto);
    }
}
