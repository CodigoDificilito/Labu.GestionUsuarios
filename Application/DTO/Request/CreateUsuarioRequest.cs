using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Request
{
    public class CreateUsuarioRequest
    {
        public string UsuarioEmail { get; set; }
        public string UsuarioContraseña { get; set; }
    }
}
