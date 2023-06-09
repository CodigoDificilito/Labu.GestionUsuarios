﻿using Application.Interfaces.IUsuario;
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
    public class UsuarioQuery: IUsuarioQuery
    {
        private readonly AppDbContext _context;

        public UsuarioQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> GetUsuarioById(int usuarioId)
        {
            var usuario = await _context.Usuario.FindAsync(usuarioId);
            return usuario;
        }

        public async Task<List<Usuario>> GetListUsuario()
        {
            var usuarios = await _context.Usuario.ToListAsync();
            return usuarios;
        }
    }
}
