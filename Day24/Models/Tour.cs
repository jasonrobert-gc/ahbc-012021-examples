using System;
using System.ComponentModel.DataAnnotations;

namespace Day24.Models
{
    public class Tour
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
    }
}
