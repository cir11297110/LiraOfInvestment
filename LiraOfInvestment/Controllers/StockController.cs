using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LiraOfInvestment.Controllers
{
    public class StockController : Controller
    {
        private IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        public IActionResult Index()
        {
            return View(_stockService.GetAll());
        }
    }
}
