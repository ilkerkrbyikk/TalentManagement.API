using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalentManagement.Domain.Common;

namespace TalentManagement.API.Controllers.BaseController
{
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        protected IActionResult HandleResult<T>(BusinessResult<T> result)
        {
            if (result.Success)
            {
                return Ok(result.Value);
            }

            return BadRequest(new ErrorResponse { Error = result.Error });
        }

        protected IActionResult HandleResultCreated<T>(BusinessResult<T> result, string actionName, object routeValues)
        {
            if (result.Success)
            {
                return CreatedAtAction(actionName, routeValues, result.Value);
            }

            return BadRequest(new ErrorResponse { Error = result.Error });
        }

        protected IActionResult HandleResultNoContent<T>(BusinessResult<T> result)
        {
            if (result.Success)
            {
                return NoContent();
            }

            return BadRequest(new ErrorResponse { Error = result.Error });
        }

        protected IActionResult HandleResultNotFound<T>(BusinessResult<T> result)
        {
            if (result.Success)
            {
                return Ok(result.Value);
            }

            return NotFound(new ErrorResponse { Error = result.Error });
        }
    }

    public class ErrorResponse
    {
        public string Error { get; set; }
    }
}
