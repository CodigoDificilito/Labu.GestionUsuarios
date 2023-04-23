using Application.Interfaces.IUsuario;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario(CreateUsuarioRequest request)
        {
            var result = await _service.CrearUsuario(request);
            return new JsonResult(result) {StatusCode = 201};
        }
        
    }
}
