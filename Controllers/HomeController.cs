using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NightCitySubnet.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NightCitySubnet.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ScreamSheets()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Biotechnica()
        {
            return View();
        }

        public IActionResult Sponsors()
        {
            return View();
        }

        public IActionResult Arasaka()
        {
            return View();
        }

        public IActionResult Nicola()
        {
            return View();
        }

        public IActionResult DarkWeb()
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
