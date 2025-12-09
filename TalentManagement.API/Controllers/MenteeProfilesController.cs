using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalentManagement.API.Controllers.BaseController;
using TalentManagement.Application.MenteeProfiles.DTOs;
using TalentManagement.Application.MenteeProfiles.Queries.GetMenteeProfileById;

namespace TalentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenteeProfilesController : BaseApiController
    {
        private readonly IMediator _mediator;

        public MenteeProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MenteeProfileDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(long id)
        {
            var query = new GetMenteeProfileByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (!result.Success) return NotFound(result.Error);

            return Ok(result.Value);
        }


    }
}
