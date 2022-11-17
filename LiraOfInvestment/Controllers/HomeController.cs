using Business.Abstract;
using Data.Concrete.EfCore;
using Entity.Concrete;
using LiraOfInvestment.Models;
using LiraOfInvestment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            
            var model = new MainPageItems
            {
                RecommendedStocks = GetRecommendedStocks()
            };
           
            return View(model);

        }
        public RecommendedStocks GetRecommendedStocks()
        {
            //var symbol=stockDetail.symbol;
            string BaseUrl = "https://yh-finance.p.rapidapi.com/stock/v2/";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "8fca6e9c22mshf749152c28189b6p149178jsn244430972a88");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "yh-finance.p.rapidapi.com");
                string url = string.Format("get-recommendations?symbol=INTC");
                HttpResponseMessage resp = client.GetAsync(url).Result;
                if (resp.IsSuccessStatusCode)
                {
                    var body = resp.Content.ReadAsStringAsync().Result;
                    var detail = JsonConvert.DeserializeObject<RecommendedStocks>(body);
                    return detail;
                }
                else
                {
                    return null;
                }
            }
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