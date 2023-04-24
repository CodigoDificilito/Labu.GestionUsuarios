using Application.Interfaces.IPersona;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class PersonaQuery : IPersonaQuery
    {
        private readonly AppDbContext _context;

        public PersonaQuery(AppDbContext context)
        {
            _context = context;
        }

        public List<Persona> GetListPersona()
        {
            throw new NotImplementedException();
        }

        public Persona GetListPersona(int PersonaId)
        { 
            throw new NotImplementedException(); 
        }
    }
}
