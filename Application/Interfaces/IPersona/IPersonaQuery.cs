using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IPersona
{
    public interface IPersonaQuery
    {
        public Task<Persona> GetPersonaById(int personaId);
        public Task<List<Persona>> GetListaPersonas();
    }
}
