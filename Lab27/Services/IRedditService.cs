using Lab27.Services.Models;
using System.Threading.Tasks;

namespace Lab27.Services
{
    public interface IRedditService
    {
        Task<RedditResponse> QuerySubredditAsync(string name);
    }
}
