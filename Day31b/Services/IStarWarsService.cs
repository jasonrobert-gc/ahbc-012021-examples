using Day31b.Models;
using System.Threading.Tasks;

namespace Day31b.Services
{
    public interface IStarWarsService
    {
        Task<PersonCollection> GetPeopleAsync();
        Task<Person> GetPersonAsync(int id);
    }
}