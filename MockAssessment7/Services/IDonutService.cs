using MockAssessment7.Models;
using System.Threading.Tasks;

namespace MockAssessment7.Services
{
    public interface IDonutService
    {
        Task<Donut> Search(int id);
    }
}