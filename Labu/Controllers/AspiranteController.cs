using Application.DTO.Request;
using Application.Interfaces.IAspirante;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspiranteController : ControllerBase
    {
        private readonly IAspiranteCommandService _commandService;
        private readonly IAspiranteQueryService _queryService;

        public AspiranteController(IAspiranteCommandService commandService, IAspiranteQueryService queryService)
        {
            _commandService = commandService;
            _queryService = queryService;
        }

        [HttpPost("/Aspirante/Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateAspirante(CreateAspiranteRequest request)
        {
            var result = await _commandService.CreateAspirante(request);
            return StatusCode(result.code, result.result);
        }

        [HttpGet("/Aspirante/GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult>GetAspiranteById(int id)
        {
            var result = await _queryService.GetAspiranteById(id);
            return StatusCode(result.code, result.result);
        }

        [HttpGet("/Aspirante/GetAll")]
        public async Task<IActionResult> GetAllAspirantes()
        {
            var result = _queryService.GetListaAspirante();
            return new JsonResult(result);
        }
    }
}
