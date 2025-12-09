using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalentManagement.API.Controllers.BaseController;
using TalentManagement.Application.MentorProfiles.Commands;

namespace TalentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorProfilesController : BaseApiController
    {
        private readonly IMediator _mediator;

        public MentorProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [ProducesResponseType(typeof(long), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateMentorProfileCommand request)
        {
            var result = await _mediator.Send(request);

            if (!result.Success)
            {
                return BadRequest(new { message = result.Error });
            }

            // Şimdilik hata vermemesi için aşağıya boş bir GetById metodu koydum.
            return CreatedAtAction(nameof(GetById), new { id = result.Value }, result.Value);
        }


        /// <summary>
        /// ID'si verilen Mentorun detaylarını getirir.
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(long id)
        {
           
            return StatusCode(StatusCodes.Status501NotImplemented, "Henüz detaylarını çekme kodunu yazmadık!");

        }
    }
}
