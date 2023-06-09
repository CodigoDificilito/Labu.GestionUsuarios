﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IUsuario
{
    public interface IUsuarioQuery
    {
        public Task<Usuario> GetUsuarioById(int usuarioId);
        public Task<List<Usuario>>GetListUsuario();
    }
}
