using System.ComponentModel.DataAnnotations;

namespace Day21_DependencyInjection.Models
{
    public class PokemonViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public string MoveSet { get; set; }
        public int HP { get; set; }
        public CutenessLevel Cuteness { get; set; }
    }
}
