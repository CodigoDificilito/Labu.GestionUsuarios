using Application.Interfaces.IPersona;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class PersonaQuery:IPersonaQuery
    {
        private readonly AppDbContext _context;

        public PersonaQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Persona> GetPersonaById(int personaId)
        {
            var persona = await _context.Persona.FindAsync(personaId);
            return persona;
        }
        
        public async Task<List<Persona>> GetListaPersonas()
        {
            var personas = await _context.Persona.ToListAsync();
            return personas;
        }


    }
}
