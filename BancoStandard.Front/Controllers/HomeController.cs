using BancoStandard.Front.Models;
using BancoStandard.Front.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BancoStandard.Front.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContractService _contractservice;

        public HomeController(ILogger<HomeController> logger, IContractService contractservice)
        {
            _logger = logger;
            _contractservice = contractservice;
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
    }
}
