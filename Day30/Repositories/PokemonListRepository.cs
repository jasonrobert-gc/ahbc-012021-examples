using Day30.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day30.Repositories
{
    public class PokemonListRepository : IPokemonRepository
    {
        private readonly List<Pokemon> _list = new List<Pokemon>();

        public PokemonListRepository()
        {
            _list.Add(new Pokemon
            {
                Id = 1,
                Name = "Pikachu",
                Cuteness = CutenessLevel.Good,
                Type = PokemonType.Electric,
                HP = 100,
                MoveSet = "Thunderbolt"
            });
            _list.Add(new Pokemon
            {
                Id = 2,
                Name = "Noibat",
                Cuteness = CutenessLevel.Bad,
                Type = PokemonType.Dark,
                HP = 100,
                MoveSet = "Flap"
            });
        }

        public void Create(Pokemon model)
        {
            model.Id = _list.Count + 1;
            _list.Add(model);
        }

        public void Delete(int id)
        {
            var delete = _list.FirstOrDefault(x => x.Id == id);
            _list.Remove(delete);
        }

        public void Update(int id, Pokemon model)
        {
            _list[id] = model;
        }

        public IEnumerable<Pokemon> GetAll()
        {
            return _list;
        }
    }
}
