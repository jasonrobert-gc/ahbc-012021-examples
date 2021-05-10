using Day30.Models;
using System.Collections.Generic;

namespace Day30.Repositories
{
    public interface IPokemonRepository
    {
        IEnumerable<Pokemon> GetAll();
        void Create(Pokemon model);
        void Delete(int id);
        void Update(int id, Pokemon model);
    }
}
