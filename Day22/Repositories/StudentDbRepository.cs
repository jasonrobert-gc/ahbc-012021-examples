using Day22.Data;
using Day22.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day22.Repositories
{
    public class StudentDbRepository : IStudentRepository
    {
        private readonly SchoolContext _context;

        public StudentDbRepository(SchoolContext context)
        {
            _context = context;
        }

        public List<Student> Get()
        {
            return _context.Students.ToList();
        }

        public void Save(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
