using Business.Abstract;
using Data.Concrete.EfCore;
using LiraOfInvestment.Models;
using LiraOfInvestment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiraOfInvestment.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IStockService? _stockService;
        
        

        public HomeController(IStockService stockService)
        {
            stockService = _stockService;
            
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