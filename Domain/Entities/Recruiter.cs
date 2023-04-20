using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Recruiter
    {
        public int RecruiterId { get; set; }
        public int PersonaId { get; set; }
        public int EmpresaId { get; set; }


        public Persona Persona { get; set; }
        public Empresa Empresa { get; set; }
    }
}
