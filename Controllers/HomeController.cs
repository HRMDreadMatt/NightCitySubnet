using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NightCitySubnet.Models;
using System.Diagnostics;
using System.IO;

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

        [Route("Home/Arasaka/About")]
        public IActionResult ArasakaAbout()
        {
            return View();
        }

        public IActionResult Nicola()
        {
            return View();
        }

        public IActionResult Deep()
        {
            return View();
        }

        public IActionResult Voodoo()
        {
            return View();
        }

        public static string DeepJson()
        {
            JObject secret = JObject.Parse(System.IO.File.ReadAllText(@".\Data\deep.json"));

            using (StreamReader file = System.IO.File.OpenText(@".\Data\deep.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject readSecret = (JObject)JToken.ReadFrom(reader);
            }

            var newSecret = secret.ToString();
            var adjustJson = JsonConvert.DeserializeObject(newSecret).ToString();
            string final = adjustJson.Split('\"')[3];

            return final;          
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
