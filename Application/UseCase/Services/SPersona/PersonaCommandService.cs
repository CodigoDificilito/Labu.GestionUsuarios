using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces.IPersona;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SPersona
{
    public class PersonaCommandService:IPersonaCommandService
    {
        private readonly IPersonaCommand _command;

        public PersonaCommandService(IPersonaCommand command)
        {
            _command = command;
        }

        public async Task<ResponseMessage> CreatePersona(CreatePersonaRequest request)
        {
            var persona = new Persona
            {
                UsuarioId = request.UsuarioId,
                DNI = request.DNI,
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Telefono = request.Telefono,
                Provincia = request.Provincia,
                Ciudad = request.Ciudad,
                FechaNacimiento = request.FechaNacimiento,
            };
            await _command.CreatePersona(persona);
            var result = new CreatePersonaResponse
            {
                UsuarioId = request.UsuarioId,
                DNI = request.DNI,
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Telefono = request.Telefono,
                Provincia = request.Provincia,
                Ciudad = request.Ciudad,
                FechaNacimiento = request.FechaNacimiento,
            };
            return new ResponseMessage(201, result);
        }
    }
}
