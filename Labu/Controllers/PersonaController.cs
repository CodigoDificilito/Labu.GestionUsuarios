using Application.Dto.Request;
using Application.Interfaces.IPersona;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaServices _services;

        public PersonaController(IPersonaServices s)
        {
            _services = s;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return new JsonResult(new { nombre = "labu" });
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersona(CreatePersonaRequest request)
        {
            var result = await _services.CrearPersona(request);
            return new JsonResult(result) { StatusCode = 201 };
        }

    }
}
