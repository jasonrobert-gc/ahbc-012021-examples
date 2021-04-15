using Day21_DependencyInjection.Models;
using System.Collections.Generic;

namespace Day21_DependencyInjection.Repositories
{
    public interface IPokemonRepository
    {
        IEnumerable<PokemonViewModel> GetAll();
        void Create(PokemonViewModel model);
        void Delete(int id);
    }
}
