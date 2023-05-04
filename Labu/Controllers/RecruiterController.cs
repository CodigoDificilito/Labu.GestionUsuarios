using Application.DTO.Request;
using Application.Interfaces.IRecruiter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecruiterController : ControllerBase
    {
        private readonly IRecruiterCommandService _commandService;
        private readonly IRecuiterQueryService _queryService;
        public RecruiterController(IRecruiterCommandService commandService, IRecuiterQueryService queryService)
        {
            _commandService = commandService;
            _queryService = queryService;
        }

        [HttpPost("/Recruiter/Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateRecruiter(CreateRecruiterRequest request)
        {
            var result = await _commandService.CreateRecruiter(request);
            return StatusCode(201,result);
        }

        [HttpGet("/Recruiter/GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult>GetRecruiterById(int recruiterId)
        {
            var result = await _queryService.GetRecruiterById(recruiterId);
            return StatusCode(201,result);

        }

        [HttpGet("/Recruiter/GetListaRecruiters")]
        public async Task<IActionResult> GetListaRecruiters()
        {
            var result = await _queryService.GetRecruiterList();
            return new JsonResult(result);
        }
    }
}
