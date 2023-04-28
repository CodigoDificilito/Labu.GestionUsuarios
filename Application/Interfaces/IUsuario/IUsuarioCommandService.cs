using Application.DTO.Request;
using Application.DTO.Response;

using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IUsuario
{
    public interface IUsuarioCommandService
    {
        public Task<ResponseMessage> CrearUsuario(CreateUsuarioRequest request);
        public Task<ResponseMessage> UpdateUsuario(CreateUsuarioUpdateRequest request);
    }
}
