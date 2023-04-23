﻿using Application.Response;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IUsuario
{
    public interface IUsuarioService
    {
        Task<CreateUsuarioResponse> CrearUsuario(CreateUsuarioRequest request);
    }
}