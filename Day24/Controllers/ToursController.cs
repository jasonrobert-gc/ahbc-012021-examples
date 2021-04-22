using Day24.Models;
using Day24.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Day24.Controllers
{
    public class ToursController : Controller
    {
        private readonly ITourRepository _repository;

        public ToursController(ITourRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var results = await _repository.Get();
            return View(results);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var results = await _repository.Get(id.Value);
            return View(results);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tour model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _repository.Create(model);
            return RedirectToAction("Index");
        }
    }
}
