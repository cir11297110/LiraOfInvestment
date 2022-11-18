using Business.Abstract;
using Entity.Concrete;
using Entity.Concrete.Search;
using LiraOfInvestment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LiraOfInvestment.Controllers
{
    public class SearchController : Controller
    {
        IStockService _stockService;

        public SearchController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public IActionResult Search(string q)
        {
            var model = new StockListViewModel
            {
                Stock=_stockService.GetBySearch(q)
            };
            return PartialView(model);
        }

       
    }
}
