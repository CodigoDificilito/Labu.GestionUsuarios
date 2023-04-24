using Application.Dto.Responses;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IPersona
{
    public interface IPersonaServices
    {
        public Task<AddPersonaResponse> CrearPersona(CreatePersonaRequest request);

    }
}
