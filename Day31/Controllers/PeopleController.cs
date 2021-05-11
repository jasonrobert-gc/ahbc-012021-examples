using Day31.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly List<Person> _people;

        public PeopleController()
        {
            _people = new List<Person> 
            {
                new Person { Id = 1, FirstName = "Jason", LastName = "Robert"},
                new Person { Id = 2, FirstName = "Raffaele", LastName = "Luliani"},
            };
        }

        // GET /api/people
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_people);
        }

        // GET /api/people/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _people.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }
    }
}
