using Application.Interfaces.IAspirante;
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
    public class AspiranteQuery:IAspiranteQuery
    {
        private readonly AppDbContext _context;

        public  AspiranteQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Aspirante> GetAspiranteById(int id)
        {
           var aspirante = await _context.Aspirante.FindAsync(id);
            return aspirante;
        }

        public async Task<List<Aspirante>> GetAspirantes()
        {
            var aspirantes = await _context.Aspirante.ToListAsync();
            return aspirantes;
        }
    }
}
