using Application.Interfaces.IEmpresa;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class EmpresaCommand: IEmpresaCommand
    {
        private readonly AppDbContext _context;

        public EmpresaCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateEmpresa(Empresa empresa)
        {
            _context.Add(empresa);
            await _context.SaveChangesAsync();
        }
    }
}
