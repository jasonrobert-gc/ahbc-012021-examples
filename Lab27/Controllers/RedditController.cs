using Lab27.Models;
using Lab27.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27.Controllers
{
    public class RedditController : Controller
    {
        private readonly IRedditService _service;

        public RedditController(IRedditService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _service.QuerySubredditAsync("r/aww");

            var model = response.data.children.Select(x => new RedditViewModel(x.data.title, x.data.thumbnail, x.data.url));
            //var model = new List<RedditViewModel>();
            //foreach (var item in response.data.children)
            //{
            //    model.Add(new RedditViewModel(item.data.title, item.data.thumbnail, item.data.url));
            //}

            return View(model);
        }
    }
}
