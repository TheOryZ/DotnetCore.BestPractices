using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        // TODO : We need to define dto objects and endpoints.. Just added for example
        private readonly IServiceGeneric<Person> _serviceGeneric;
        public PersonsController(IServiceGeneric<Person> serviceGeneric)
        {
            _serviceGeneric = serviceGeneric;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _serviceGeneric.GetAllAsync());
        }
    }
}
