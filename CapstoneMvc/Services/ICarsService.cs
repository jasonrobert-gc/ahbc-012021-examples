using CapstoneApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapstoneMvc.Services
{
    public interface ICarsService
    {
        Task<IEnumerable<Car>> Search(SearchCarRequest request);
    }
}