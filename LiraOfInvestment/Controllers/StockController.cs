using Business.Abstract;
using Entity.Concrete;

using LiraOfInvestment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

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
            var model = new StockListViewModel
            {
                StockLists = _stockService.GetAll()
            };
            return View(model);
        }




        // GET: StockController/Details/AAPL
        [HttpGet("stock/details/{symbol}")]
        public  IActionResult Details(string symbol)
        {
            StockDetail stockDetail = new StockDetail();
            stockDetail.symbol = symbol;
            var company = GetStockDetail(symbol);
            return View(company);          
        }

        

        public StockDetail GetStockDetail(string symbol)
        {
            //var symbol=stockDetail.symbol;
            string BaseUrl = "https://yh-finance.p.rapidapi.com/stock/v2/";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "8fca6e9c22mshf749152c28189b6p149178jsn244430972a88");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "yh-finance.p.rapidapi.com");
                string url = string.Format("get-summary?symbol={0}&region=US",symbol);
                HttpResponseMessage resp = client.GetAsync(url).Result;
                if (resp.IsSuccessStatusCode)
                {
                    var body = resp.Content.ReadAsStringAsync().Result;
                    var detail = JsonConvert.DeserializeObject<StockDetail>(body);
                    return detail;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
