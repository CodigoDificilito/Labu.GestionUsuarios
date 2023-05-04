using Application.Interfaces.IEmpresa;
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
    public class EmpresaQuery : IEmpresaQuery
    {
        private readonly AppDbContext _context;

        public EmpresaQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Empresa> GetEmpresaById(int empresaId)
        {
            var empresa = await _context.Empresa.FindAsync(empresaId);

            return empresa;
        }
        public async Task<List<Empresa>> GetListaEmpresa()
        {
            var lista = await _context.Empresa.ToListAsync();
            return lista;
        }
    }
}
