using Application.Dto.Responses;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Responses
{
    public interface RemovePersonaResponse
    {
        public int DNI { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Telefono { get; set; }

        public string Provincia { get; set; }

        public string Ciudad { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
