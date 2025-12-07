using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalentManagement.API.Controllers.BaseController;
using TalentManagement.Application.MenteeProfile.Commands.CreateMenteeProfile;

namespace TalentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator _mediator) : ControllerBase
    {

        /// <summary>
        /// Yeni mentee profili oluşturur
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(long), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(
            [FromBody] CreateMenteeProfileCommand request,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);

            if (!result.Success)
            {
                return BadRequest(new ErrorResponse
                {
                    Error = result.Error
                });
            }

            return CreatedAtAction(
                nameof(GetById),
                new { id = result.Value },
                new { id = result.Value }
            );
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
                       // Placeholder for CreatedAtAction to reference
            return Ok();
        }
    }
}
