using Day21_DependencyInjection.Models;
using Day21_DependencyInjection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day21_DependencyInjection.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _repository;

        public PokemonController(IPokemonRepository repository)
        {
            _repository = repository;
        }

        // GET: PokemonController
        public IActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PokemonViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Create(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
         
            _repository.Delete(id.Value);
            return RedirectToAction("Index");
        }
    }
}
