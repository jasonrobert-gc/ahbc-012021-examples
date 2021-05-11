using Day31b.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Day31b.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IStarWarsService _service;

        public PeopleController(IStarWarsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var people = await _service.GetPeopleAsync();
            return View(people.Results);
        }
    }
}
