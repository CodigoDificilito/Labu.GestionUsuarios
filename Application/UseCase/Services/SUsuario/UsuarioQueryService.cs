using Application.DTO;
using Application.DTO.Response;
using Application.Interfaces.IUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SUsuario
{
    public class UsuarioQueryService: IUsuarioQueryService
    {
        private readonly IUsuarioQuery _query;

        public UsuarioQueryService(IUsuarioQuery query)
        {
            _query = query;
        }

        public async Task <ResponseMessage> GetUsuarioById(int usuarioId)
        {
            var usuario = await _query.GetUsuarioById(usuarioId);
            if (usuario == null)
            {
                return new ResponseMessage(404, new { request = "Oferta no encontrada." });
            }
            return new ResponseMessage(201, new UsuarioDTO()
            {
                Email = usuario.Email,
                Contraseña = usuario.Contraseña
            });
        }

        public async Task<List<UsuarioDTO>> GetListaUsuario()
        {
            var usuarios = await _query.GetListUsuario();
            var usuariosDTO = new List<UsuarioDTO>();

            foreach (var item in usuarios)
            {
                var usuarioDTO = new UsuarioDTO()
                {
                    Email= item.Email,
                    Contraseña= item.Contraseña
                };
                usuariosDTO.Add(usuarioDTO);
            }
            return usuariosDTO;
        }


    }
}
