using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Request
{
    public class CreateEmpresaRequest
    {
        public int UsuarioId { get; set; }
        public string Logo { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string SectorEmpresarial { get; set; }
        public string PaginaWeb { get; set; }
        public string Descripcion { get; set; }
    }
}
