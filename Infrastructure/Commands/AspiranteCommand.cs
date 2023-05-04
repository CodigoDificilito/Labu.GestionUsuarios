using Application.Interfaces.IAspirante;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class AspiranteCommand:IAspiranteCommand
    {
        private readonly AppDbContext _context;

        public AspiranteCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAspirante(Aspirante aspirante)
        {
            _context.Add(aspirante);

            await _context.SaveChangesAsync();
        }
    }
}
