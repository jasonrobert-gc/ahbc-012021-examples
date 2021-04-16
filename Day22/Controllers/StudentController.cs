﻿using Day22.Data.Models;
using Day22.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Day22.Controllers
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
        public IActionResult Create(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _repository.Save(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _repository.Get().FirstOrDefault(x => x.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Student model)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _repository.Get().FirstOrDefault(x => x.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            //student.DateOfBirth = model.DateOfBirth;

            return RedirectToAction("Index");
        }
    }
}
