using Day19.Models;
using Day19.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Day19.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var students = _repository.Get();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            _repository.Save(model);
            return RedirectToAction("Index");
        }
    }
}
