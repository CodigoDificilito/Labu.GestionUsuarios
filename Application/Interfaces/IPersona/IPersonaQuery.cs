using Application.Dto;
using Domain.Entities;


namespace Application.Interfaces.IPersona
{
    public interface IPersonaQuery
    {
        public List<Persona> GetListPersona();

        public Persona GetListPersona(int PersonaId);
    }
}
