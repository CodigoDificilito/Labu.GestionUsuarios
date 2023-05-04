using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IAspirante
{
    public interface IAspiranteQuery
    {
        Task<Aspirante> GetAspiranteById(int id);
        Task<List<Aspirante>> GetAspirantes();
    }
}
