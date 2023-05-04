using Application.DTO.Request;
using Application.Interfaces.IUsuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioCommandService _service;
        private readonly IUsuarioQueryService _queryService;

        public UsuarioController(IUsuarioCommandService service, IUsuarioQueryService queryService)
        {
            _service = service;
            _queryService = queryService;

        }

        [HttpPost("/Usuario/Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateUsuario(CreateUsuarioRequest request)
        {
            var result = await _service.CrearUsuario(request);
            return StatusCode(result.code, result.result);
        }
        [HttpPost("/Usuario/Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateUsuario(CreateUsuarioUpdateRequest request)
        {
            var result = await _service.UpdateUsuario(request);
            return StatusCode(result.code, result.result);
        }


        [HttpGet("/Usuario/GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult>GetUsuarioById(int usuarioId)
        {
            var result = await _queryService.GetUsuarioById(usuarioId);
            return StatusCode(result.code, result.result);
        }

        [HttpGet("/Usuario/GetListUsuario")]
        public async Task<IActionResult> GetAllUsuarios()
        {
            var result = await _queryService.GetListaUsuario();
            return new JsonResult(result);

        }

    }   
}
