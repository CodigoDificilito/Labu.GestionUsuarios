using Application.DTO;
using Application.DTO.Response;
using Application.Interfaces.IPersona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SPersona
{
    public class PersonaQueryService:IPersonaQueryService
    {
        private readonly IPersonaQuery _query;

        public PersonaQueryService(IPersonaQuery query)
        {
            _query = query;
        }

        public async Task<ResponseMessage> GetPersonaById(int id)
        {
            var persona = await _query.GetPersonaById(id);
            if (persona == null)
            {
                return new ResponseMessage(404, new { request = "Persona no encontrada" });
            }
            return new ResponseMessage(200, new PersonaDTO()
            {
                UsuarioId = persona.UsuarioId,
                DNI= persona.DNI,
                Nombre= persona.Nombre,
                Apellido= persona.Apellido,
                Telefono= persona.Telefono,
                Provincia= persona.Provincia,
                Ciudad= persona.Ciudad,
                FechaNacimiento=persona.FechaNacimiento

            });
        }

        public async Task<List<PersonaDTO>> GetListaPersonas()
        {
            var personas = await _query.GetListaPersonas();
            var personasDTO = new List<PersonaDTO>();

            foreach (var item in personas)
            {
                var personaDTO = new PersonaDTO()
                {
                    UsuarioId = item.UsuarioId,
                    DNI= item.DNI,
                    Nombre= item.Nombre,
                    Apellido= item.Apellido,
                    Telefono= item.Telefono,
                    Provincia= item.Provincia,
                    Ciudad= item.Ciudad,
                    FechaNacimiento= item.FechaNacimiento
                };
                personasDTO.Add(personaDTO);
            }
            return personasDTO;
        }


    }
}
