using Microsoft.AspNetCore.Identity;
using System;

namespace Day27.Models
{
    public class ShoppingListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public IdentityUser User { get; set; }
    }
}
