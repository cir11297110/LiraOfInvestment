using LiraOfInvestment.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace LiraOfInvestment.Data.Repositories
{
    public class StockListRepository
    {
        private HttpClient _httpClient;

        public StockListRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<StockList> GetMainPageItems()
        {
            
            string BaseUrl = "https://financialmodelingprep.com/api/";
            _httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //_httpClient.DefaultRequestHeaders.Add("x-api-key", "EUo6ZbferP7X1ae75hMEH8S4SzVNJNAH6LHF0TG0");
            List<StockList> stockList = new List<StockList>();
            string url = string.Format("v3/stock/list?apikey=39f3e7c61645193688dd11330fd462c7");

            HttpResponseMessage resp = _httpClient.GetAsync(url).Result;

            if (resp.IsSuccessStatusCode)
            {
                var dailyResponse = resp.Content.ReadAsStringAsync().Result;
                stockList = JsonConvert.DeserializeObject<List<StockList>>(dailyResponse);
            }
            return stockList;
        }
    }
}
