using Day19.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Day19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //[ViewData]
        //public string CurrentTime { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();

            TempData["CurrentTime"] = DateTime.Now.ToString();

            HttpContext.Session.SetString("CurrentTime", DateTime.Now.ToString());

            var cookieOptions = new CookieOptions { Expires = DateTime.Now.AddSeconds(30) };
            HttpContext.Response.Cookies.Append("CurrentTime", DateTime.Now.ToString(), cookieOptions);

            // Newer approach but, hasn't really stuck
            //CurrentTime = DateTime.Now.ToString();

            // Legacy
            //ViewBag.CurrentTime = DateTime.Now.ToString();

            return View();
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
