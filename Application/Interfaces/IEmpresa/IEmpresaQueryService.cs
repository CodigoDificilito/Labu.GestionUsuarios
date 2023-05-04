using Application.DTO;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IEmpresa
{
    public interface IEmpresaQueryService
    {
        Task<ResponseMessage> GetEmpresaById(int id);
        public Task<List<EmpresaDTO>> GetListaEmpresa();
    }
}
