using Day24.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day24.Repositories
{
    public interface ITourRepository
    {
        Task Create(Tour movie);
        Task Delete(int id);
        Task<bool> Exists(int id);
        Task<List<Tour>> Get();
        Task<Tour> Get(int id);
        Task Update(Tour movie);
    }
}
