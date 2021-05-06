using Microsoft.AspNetCore.Identity;

namespace Day29.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public int Age { get; set; }

        [PersonalData]
        public string FirstName { get; set; }
        
        [PersonalData]
        public string LastName { get; set; }
    }
}
