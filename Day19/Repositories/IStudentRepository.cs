using Day19.Models;
using System.Collections.Generic;

namespace Day19.Repositories
{
    public interface IStudentRepository
    {
        List<StudentViewModel> Get();
        void Save(StudentViewModel student);
    }
}
