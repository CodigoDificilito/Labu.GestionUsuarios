using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public int UsuarioId { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }


        public Usuario Usuario { get; set; }
        public Recruiter Recruiter { get; set; }
        public Aspirante Aspirante { get; set; }

    }
}
