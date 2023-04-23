using Application.Interfaces.IUsuario;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class UsuarioCommand: IUsuarioCommand
    {
        private readonly AppDbContext _context;

        public UsuarioCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }

    }
}
