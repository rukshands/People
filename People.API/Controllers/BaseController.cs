using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected internal IActionResult OkResponse<T>(T data)
        {
            var response = new ServiceResponse<T>
            {
                ResultCode = ResultCode.Success,
                Data = data
            };

            return Ok(response);
        }

        protected internal IActionResult NotFoundResponse()
        {
            var response = new ServiceResponse
            {
                ResultCode = ResultCode.NotFound,
                Data = null
            };

            return NotFound(response);
        }

        protected internal IActionResult BadRequestResponse()
        {
            var response = new ServiceResponse
            {
                ResultCode = ResultCode.ValidationError,
                Data = null
            };

            return BadRequest(response);
        }

        protected internal IActionResult ErrorResponse(Exception e)
        {
            var response = new ServiceResponse
            {
                ResultCode = ResultCode.ServerError,
                Data = null,
                Error = e.Message
            };

            return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }
}
