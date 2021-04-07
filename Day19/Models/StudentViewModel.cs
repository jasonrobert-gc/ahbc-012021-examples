using System;
using System.ComponentModel.DataAnnotations;

namespace Day19.Models
{
    public class StudentViewModel
    {
        [Display(Name = "First Name")]
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string LastName { get; set; }
        
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
