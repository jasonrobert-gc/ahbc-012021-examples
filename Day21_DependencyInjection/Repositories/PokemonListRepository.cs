using Day21_DependencyInjection.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day21_DependencyInjection.Repositories
{
    public class PokemonListRepository : IPokemonRepository
    {
        private readonly List<PokemonViewModel> _list = new List<PokemonViewModel>();

        public PokemonListRepository()
        {
            _list.Add(new PokemonViewModel
            {
               Id = 1,
               Name = "Pikachu",
               Cuteness = CutenessLevel.Good,
               Type = PokemonType.Electric,
               HP = 100,
               MoveSet = "Thunderbolt"
            });
            _list.Add(new PokemonViewModel
            {
                Id = 2,
                Name = "Noibat",
                Cuteness = CutenessLevel.Bad,
                Type = PokemonType.Dark,
                HP = 100, 
                MoveSet = "Flap"
            });
        }

        public void Create(PokemonViewModel model)
        {
            model.Id = _list.Count + 1;
            _list.Add(model);
        }

        public void Delete(int id)
        {
            var delete = _list.FirstOrDefault(x => x.Id == id);
            _list.Remove(delete);
        }

        public IEnumerable<PokemonViewModel> GetAll()
        {
            return _list;
        }
    }
}
