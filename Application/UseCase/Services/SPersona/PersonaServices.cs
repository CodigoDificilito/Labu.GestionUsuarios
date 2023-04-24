using Application.Interfaces.IPersona;
using Application.Dto;
using Application.Dto.Request;
using Application.Dto.Responses;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SPersona
{
    public class PersonaServices : IPersonaServices
    {
        private readonly IPersonaCommand _command;
        private readonly IPersonaQuery _query;

        public PersonaServices(IPersonaCommand command, IPersonaQuery query)
        {
            _command = command;
            _query = query;
        }

        public async Task<AddPersonaResponse> CrearPersona(CreatePersonaRequest request)
        {
            var persona = new Persona
            {
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                DNI = request.DNI,
                Telefono = request.Telefono,
                Provincia = request.Provincia,
                Ciudad = request.Ciudad,
                FechaNacimiento = request.FechaNacimiento
            };

            await _command.CreatePersona(persona);
            return new AddPersonaResponse
            {
                DNI = persona.DNI,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Telefono = persona.Telefono,
                Provincia = persona.Provincia,
                Ciudad = persona.Ciudad,
                FechaNacimiento = persona.FechaNacimiento
            };
        }
    }
}
