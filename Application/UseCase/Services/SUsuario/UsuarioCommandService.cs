using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces.IUsuario;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SUsuario
{
    public class UsuarioCommandService: IUsuarioCommandService
    {
        private readonly IUsuarioCommand _command;

        public UsuarioCommandService(IUsuarioCommand command)
        {
            _command = command;
        }


        public async Task<ResponseMessage> CrearUsuario(CreateUsuarioRequest request)
        {
            var usuario = new Usuario
            {
                Email = request.UsuarioEmail,
                Contraseña = request.UsuarioContraseña
            };
            await _command.CreateUsuario(usuario);
            return new ResponseMessage(201, usuario);
        }

        public async Task<ResponseMessage> UpdateUsuario(CreateUsuarioUpdateRequest request)
        {
            var usuario = new Usuario
            {
                UsuarioId= request.UsuarioId,
                Email = request.UsuarioEmail,
                Contraseña = request.UsuarioContraseña
            };
            await _command.UpdateUsuario(usuario);

            return new ResponseMessage(201, usuario);
        }
    }
}
