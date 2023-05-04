using Application.DTO;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IAspirante
{
    public interface IAspiranteQueryService
    {
        Task<ResponseMessage> GetAspiranteById(int id);
        public Task<List<AspiranteDTO>> GetListaAspirante();
    }

}
