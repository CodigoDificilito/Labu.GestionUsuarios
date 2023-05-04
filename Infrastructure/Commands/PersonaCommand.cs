using Application.Interfaces.IPersona;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class PersonaCommand: IPersonaCommand
    {
        private readonly AppDbContext _context;

        public PersonaCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreatePersona(Persona persona)
        {
            _context.Add(persona);
            await _context.SaveChangesAsync();
        }
    }
}
