using Application.Interfaces.IUsuario;
using Application.Response;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioCommand _command;
        private readonly IUsuarioQuery _query;

        public UsuarioService(IUsuarioCommand command, IUsuarioQuery query)
        {
            _command = command;
            _query = query;
        }


        public async Task<CreateUsuarioResponse> CrearUsuario(CreateUsuarioRequest request)
        {
            var usuario = new Usuario
            {
                Email = request.UsuarioEmail,
                Contraseña = request.UsuarioContraseña 
            }; 
            await _command.CreateUsuario(usuario);
            return new CreateUsuarioResponse
            {
                UsuarioEmail = usuario.Email,
                UsuarioContraseña = usuario.Contraseña
            };
        }
    }
}
