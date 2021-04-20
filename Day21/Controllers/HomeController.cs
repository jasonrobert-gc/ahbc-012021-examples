using Day21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Day21.Controllers
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
            return View();
        }

        public IActionResult ChooseYourCookie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChooseYourCookie(CookieViewModel model)
        {
            if (model.Type.Equals("Chocolate Chip"))
            {
                return View("GoodCookies", new CookieSelectionViewModel
                {
                    Type = model.Type,
                    Flavor = "Yummy"
                });
            }
            else if (model.Type.Equals("Oatmeal Raisin"))
            {
                return View("GoodCookies", new CookieSelectionViewModel
                {
                    Type = model.Type,
                    Flavor = "THE BEST"
                });
            }

            return View("BadCookies");
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
