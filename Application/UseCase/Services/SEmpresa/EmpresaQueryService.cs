using Application.DTO;
using Application.DTO.Response;
using Application.Interfaces.IEmpresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Services.SEmpresa
{
    public class EmpresaQueryService : IEmpresaQueryService
    {
        private readonly IEmpresaQuery _query;

        public EmpresaQueryService(IEmpresaQuery query)
        {
            _query = query;
        }

        public async Task<ResponseMessage> GetEmpresaById(int id)
        {
            var empresa = await _query.GetEmpresaById(id);
            if (empresa == null)
            {
                return new ResponseMessage(404, new { request = "Empresa no encontrada" });
            }

            return new ResponseMessage(200, new EmpresaDTO()
            {
                UsuarioId = empresa.UsuarioId,
                Logo = empresa.Logo,
                Nombre = empresa.Nombre,
                Provincia= empresa.Provincia,
                Ciudad = empresa.Ciudad,
                Direccion = empresa.Direccion,
                SectorEmpresarial= empresa.SectorEmpresarial,
                PaginaWeb= empresa.PaginaWeb,
                Descripcion= empresa.Descripcion
            });
        }

        public async Task<List<EmpresaDTO>> GetListaEmpresa()
        {
            var empresas = await _query.GetListaEmpresa();
            var empresasDTO = new List<EmpresaDTO>();

            foreach (var item in empresas)
            {
                var empresaDTO = new EmpresaDTO()
                {
                    UsuarioId = item.UsuarioId,
                    Logo = item.Logo,
                    Nombre = item.Nombre,
                    Provincia= item.Provincia,
                    Ciudad = item.Ciudad,
                    Direccion= item.Direccion,
                    SectorEmpresarial = item.SectorEmpresarial,
                    PaginaWeb= item.PaginaWeb,
                    Descripcion= item.Descripcion
                };
                empresasDTO.Add(empresaDTO);
            }
            return empresasDTO;
        }
    }
}
