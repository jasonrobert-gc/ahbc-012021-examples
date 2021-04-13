using System.ComponentModel.DataAnnotations;

namespace Day20b.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
    }
}
