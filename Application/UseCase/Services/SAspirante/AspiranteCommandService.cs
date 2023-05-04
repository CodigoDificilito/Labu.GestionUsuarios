using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces.IAspirante;
using Application.Interfaces.IEmpresa;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SAspirante
{
    public class AspiranteCommandService: IAspiranteCommandService
    {
        private readonly IAspiranteCommand _command;

        public AspiranteCommandService(IAspiranteCommand command)
        {
            _command = command;
        }

        public async Task<ResponseMessage>CreateAspirante(CreateAspiranteRequest request)
        {
            var aspirante = new Aspirante 
            {
                PersonaId= request.PersonaId,
            };

            await _command.CreateAspirante(aspirante);
            var result = new CreateAspiranteResponse
            {
                AspiranteId= aspirante.AspiranteId,
                PersonaId= aspirante.PersonaId,
            };
            return new ResponseMessage(201, result);
        }

    }
}
