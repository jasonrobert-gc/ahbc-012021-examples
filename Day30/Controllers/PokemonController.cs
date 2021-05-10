using Day30.Models;
using Day30.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day30.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _repository;

        public PokemonController(IPokemonRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<TodoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _repository.GetAll().FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST api/<TodoController>
        [HttpPost]
        public IActionResult Post([FromBody] Pokemon model)
        {
            _repository.Create(model);
            return Created($"api/pokemon/{model.Id}", model);
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Pokemon model)
        {
            _repository.Update(id, model);
            return Ok();
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
