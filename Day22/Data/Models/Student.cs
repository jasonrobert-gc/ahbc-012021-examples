using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day22.Data.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
