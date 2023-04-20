using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public int UsuarioId { get; set; }
        public string Logo { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string SectorEmpresarial { get; set; }
        public string PaginaWeb { get; set; }
        public string Descripcion { get; set; }


        public Usuario Usuario { get; set; }
        public DatosContacto DatosContacto { get; set; }
        public IList<Recruiter> Recruiter { get; set; }
    }
}
