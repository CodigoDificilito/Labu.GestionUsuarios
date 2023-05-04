using Application.DTO.Request;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IEmpresa
{
    public interface IEmpresaCommandService
    {
        public Task<ResponseMessage> CreateEmpresa(CreateEmpresaRequest request);
    }
}
