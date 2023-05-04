using Application.DTO;
using Application.DTO.Response;
using Application.Interfaces.IAspirante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SAspirante
{
    public class AspiranteQueryService: IAspiranteQueryService
    {
        private readonly IAspiranteQuery _query;

        public AspiranteQueryService(IAspiranteQuery query)
        {
            _query = query;
        }

        public async Task<ResponseMessage> GetAspiranteById(int id)
        {
            var aspirante = await _query.GetAspiranteById(id);
            if (aspirante == null)
            {
                return new ResponseMessage(404, new { request = "Aspirante no encontrado." });
            }
            return new ResponseMessage(200, new AspiranteDTO()
            {
                PersonaId=aspirante.PersonaId,
                AspiranteId = aspirante.AspiranteId
            });
        }

        public async Task<List<AspiranteDTO>> GetListaAspirante()
        {
            var aspirantes = await _query.GetAspirantes();
            var aspirantesDTO = new List<AspiranteDTO>();
            foreach (var a in aspirantes)
            {
                var aspiranteDTO = new AspiranteDTO()
                {
                    PersonaId = a.PersonaId,
                    AspiranteId = a.AspiranteId,
                };
                aspirantesDTO.Add(aspiranteDTO);
            }

            return aspirantesDTO;    
        }
    }
}
