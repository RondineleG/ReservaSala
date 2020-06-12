using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Reserva.App.Controllers
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
        public IActionResult Reserva()
        {
            return View();
        }
        public IActionResult Aluno()
        {
            return View();
        }
        public IActionResult Bloco()
        {
            return View();
        }
        public IActionResult Sala()
        {
            return View();
        }
    }
}
