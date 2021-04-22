using Day23.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day23.Repositories
{
    public interface IMovieRepository
    {
        Task Create(Movie movie);
        Task Delete(int id);
        Task<bool> Exists(int id);
        Task<List<Movie>> Get();
        Task<Movie> Get(int id);
        Task Update(Movie movie);
    }
}
