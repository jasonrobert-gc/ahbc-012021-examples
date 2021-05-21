using Assessment7Prep.Models;
using System.Threading.Tasks;

namespace Assessment7Prep.Services
{
    public interface IDonutService
    {
        Task<Donut> Get(int id);
        Task<DonutResults> GetAll();
    }
}