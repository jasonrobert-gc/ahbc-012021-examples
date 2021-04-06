using System;
using System.ComponentModel.DataAnnotations;

namespace Day19.Models
{
    public class StudentViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
