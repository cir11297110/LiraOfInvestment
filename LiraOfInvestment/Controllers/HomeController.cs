using LiraOfInvestment.Data.Repositories;
using LiraOfInvestment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiraOfInvestment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private StockListRepository StockListRepository;

        public HomeController(StockListRepository stockListRepository)
        {
            StockListRepository = stockListRepository;
        }

       

        public IActionResult Index()
        {
            var model = StockListRepository.GetMainPageItems();
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