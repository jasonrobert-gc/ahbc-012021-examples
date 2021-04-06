using Day19.Models;
using System.Collections.Generic;

namespace Day19.Repositories
{
    public class StudentListRepository : IStudentRepository
    {
        private readonly List<StudentViewModel> _students = new List<StudentViewModel>();

        public List<StudentViewModel> Get()
        {
            return _students;
        }

        public void Save(StudentViewModel student)
        {
            _students.Add(student);
        }
    }
}
