using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces.IEmpresa;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SEmpresa
{
    public class EmpresaCommandService: IEmpresaCommandService
    {
        private readonly IEmpresaCommand _command;

        public EmpresaCommandService(IEmpresaCommand command)
        {
            _command = command;
        }

        public async Task<ResponseMessage> CreateEmpresa(CreateEmpresaRequest request)
        {
            var empresa = new Empresa
            {
                UsuarioId = request.UsuarioId,
                Logo = request.Logo,
                Nombre = request.Nombre,
                Provincia = request.Provincia,
                Ciudad = request.Ciudad,
                Direccion = request.Direccion,
                SectorEmpresarial = request.SectorEmpresarial,
                PaginaWeb = request.PaginaWeb,
                Descripcion = request.Descripcion
            };
            await _command.CreateEmpresa(empresa);
            var result = new CreateEmpresaResponse
            {

                UsuarioId = request.UsuarioId,
                Logo = request.Logo,
                Nombre = request.Nombre,
                Provincia = request.Provincia,
                Ciudad = request.Ciudad,
                Direccion = request.Direccion,
                SectorEmpresarial = request.SectorEmpresarial,
                PaginaWeb = request.PaginaWeb,
                Descripcion = request.Descripcion
            };
            return new ResponseMessage(201, result);
        }
    }
}
