using Application.DTO.Request;
using Application.Interfaces.IPersona;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaCommandService _commandService;
        private readonly IPersonaQueryService _queryService;

        public PersonaController(IPersonaCommandService commandService, IPersonaQueryService queryService)
        {
            _commandService = commandService;
            _queryService = queryService;
        }

        [HttpPost("/Persona/Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult>CreatePersona(CreatePersonaRequest request)
        {
            var result = await _commandService.CreatePersona(request);
            return StatusCode(201,result);
        }

        [HttpGet("/Persona/GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult>GetPersonaById(int personaid)
        {
            var result = await _queryService.GetPersonaById(personaid);
            return StatusCode(result.code, result.result);
        }

        [HttpGet("/Persona/GetListaPersonas")]
        public async Task<IActionResult> GetListaPersonas()
        {
            var result = await _queryService.GetListaPersonas();
            return new JsonResult(result);
        }


    }
}
