using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using People.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.API.Controllers
{
    [Route("people")]
    [ApiController]
    public class PeopleController : BaseController
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0) // simulation
                return BadRequestResponse();

            try
            {
                var person = _peopleService.GetById(id);

                if (person == null)
                    return NotFoundResponse();

                return OkResponse(person);
            }
            catch(Exception e)
            {
                return ErrorResponse(e);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var people = _peopleService.GetAll();

                return OkResponse(people);
            }
            catch (Exception e)
            {
                return ErrorResponse(e);
            }
        }
    }
}
