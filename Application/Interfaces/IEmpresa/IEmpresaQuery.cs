using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IEmpresa
{
    public interface IEmpresaQuery
    {
        public Task<Empresa> GetEmpresaById(int empresaId);
        public Task<List<Empresa>> GetListaEmpresa();
    }
}
