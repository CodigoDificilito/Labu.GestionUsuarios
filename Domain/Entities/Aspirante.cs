﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aspirante
    {
        public int AspiranteId { get; set; }
        public int PersonaId { get; set; }


        public Persona Persona { get; set; }
    }
}
