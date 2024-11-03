using Form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public RegisterData RegisterData { get; set; }

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterData data)
        {
            if (ModelState.IsValid)
            {
                RegisterData = data;
                return View("Result");
            }

            return View();
        }

        public IActionResult Clear()
        {
            return View("Register");
        }
    }
}
