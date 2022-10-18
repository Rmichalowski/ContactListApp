using ContactListApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactListApp.Controllers
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

        //POST: Home
        [HttpPost]
        public IActionResult Index(Person person)
        {
            return RedirectToAction("Index","PersonDetails", person);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}