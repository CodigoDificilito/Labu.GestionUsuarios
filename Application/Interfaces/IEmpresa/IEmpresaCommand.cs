using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IEmpresa
{
    public interface IEmpresaCommand
    {
        public Task CreateEmpresa(Empresa empresa);
    }
}
