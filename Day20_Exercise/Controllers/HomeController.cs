using Day20_Exercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Exercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //// Regular syntax
            //var color = HttpContext.Request.Cookies["Color"];
            //if (color == null)
            //{
            //    color = "#fff";
            //}

            //// ternary operator - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            //var color = HttpContext.Request.Cookies["Color"] == null ? "#fff" : HttpContext.Request.Cookies["Color"];

            //// null coalescing - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
            //var color = HttpContext.Request.Cookies["Color"] ?? "#fff";

            var model = new IndexViewModel
            {
                Color = HttpContext.Request.Cookies["Color"] ?? "#fff",
                FontSize = HttpContext.Request.Cookies["Font"] ?? "16px"
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            HttpContext.Response.Cookies.Append("Color", model.Color);
            HttpContext.Response.Cookies.Append("Font", model.FontSize);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
