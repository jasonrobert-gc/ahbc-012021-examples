using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day22.Data.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
