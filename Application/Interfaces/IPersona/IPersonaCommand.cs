﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IPersona
{
    public interface IPersonaCommand
    {
        public Task CreatePersona(Persona persona);

        public Task InsertPersona(Persona persona);

        public Task DeletePersona(Persona persona);
    }
}