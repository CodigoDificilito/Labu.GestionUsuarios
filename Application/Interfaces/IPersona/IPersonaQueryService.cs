using Application.DTO;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IPersona
{
    public interface IPersonaQueryService
    {
        public Task<ResponseMessage>GetPersonaById(int id);
        public Task<List<PersonaDTO>> GetListaPersonas();
    }
}
