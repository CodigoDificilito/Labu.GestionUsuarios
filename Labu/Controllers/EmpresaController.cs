using Application.DTO.Request;
using Application.Interfaces.IEmpresa;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaCommandService _commandService;
        private readonly IEmpresaQueryService _queryService;

        public EmpresaController(IEmpresaCommandService commandService,IEmpresaQueryService queryService)
        {
            _commandService = commandService;
            _queryService = queryService;
        }

        [HttpPost("/Empresa/Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateEmpresa(CreateEmpresaRequest request)
        {
            var result = await _commandService.CreateEmpresa(request);
            return StatusCode(result.code, result.result);
        }

        [HttpGet("/Empresa/FindById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult>GetEmpresaById(int empresaId)
        {
            var result = await _queryService.GetEmpresaById(empresaId);
            return StatusCode(result.code, result.result); 
        }

        [HttpGet("/Empresa/GetAll")]

        public async Task<IActionResult> GetAllEmpresas() 
        {
            var result = await _queryService.GetListaEmpresa();
            return new JsonResult(result);
        }
    }
}
