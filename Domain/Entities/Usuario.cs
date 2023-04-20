using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }


        public Persona Persona { get; set; }
        public Empresa Empresa { get; set; }
    }
}
