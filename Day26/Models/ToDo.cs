using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Day26.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Completed By")]
        public DateTime CompleteBy { get; set; }
        public IdentityUser User { get; set; }
    }
}
