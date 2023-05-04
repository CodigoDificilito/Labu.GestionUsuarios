using Application.DTO;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IUsuario
{
    public interface IUsuarioQueryService
    {
        public Task<ResponseMessage> GetUsuarioById(int usuarioId);
        public Task<List<UsuarioDTO>> GetListaUsuario();
    }
}
