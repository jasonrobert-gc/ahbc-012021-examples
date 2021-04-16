using Day22.Data.Models;
using System.Collections.Generic;

namespace Day22.Repositories
{
    public interface IStudentRepository
    {
        List<Student> Get();
        void Save(Student student);
    }
}
