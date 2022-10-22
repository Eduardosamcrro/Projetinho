using Microsoft.AspNetCore.Mvc;
using Projetinho.Models;
using System.Diagnostics;

namespace Projetinho.Controllers
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
    }
}