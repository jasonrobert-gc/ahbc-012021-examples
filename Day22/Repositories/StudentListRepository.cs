using Day22.Data.Models;
using System.Collections.Generic;

namespace Day22.Repositories
{
    public class StudentListRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public List<Student> Get()
        {
            return _students;
        }

        public void Save(Student student)
        {
            _students.Add(student);
        }
    }
}
