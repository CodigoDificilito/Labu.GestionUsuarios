using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Application.Dto.Request
{
    public class AddPersonaRequest
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
