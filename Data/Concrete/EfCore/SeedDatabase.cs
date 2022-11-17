using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using YahooFinanceApi;

namespace Data.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static async Task<int> GetStockData(string symbol, DateTime startDate, DateTime endDate)
        {
            

            try
            {
                var historicData=await Yahoo.GetHistoricalAsync(symbol, startDate, endDate);
                var security = await Yahoo.Symbols(symbol).Fields(Field.LongName).QueryAsync();
                var ticker = security[symbol];
                var companyName = ticker[Field.LongName];
                for(var i = 0; i < historicData.Count; i++)
                {
                    Console.WriteLine(companyName + historicData.ElementAt(i).Close);
                }
            }
            catch
            {
                Console.WriteLine("Gelemedi");
            }
            return 1;
        }
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            DateTime endDate = DateTime.Today;
            DateTime startDate = DateTime.Today.AddDays(-2);

           var awaiter=await GetStockData("AAPL",startDate,endDate);
            Console.WriteLine(awaiter);
            //GetStockData("aapl",endDate,startDate);
            //using (var context = new StockContext(
            //    serviceProvider.GetRequiredService<DbContextOptions<StockContext>>()))
            //{
            //    //context.Database.EnsureCreated();

            //    List<StockLists> stockLists = new List<StockLists>();
            //    if (!context.StockLists.Any())
            //    {


            //        using (var client = new HttpClient())
            //        {
            //            string BaseUrl = "https://financialmodelingprep.com/api/";
            //            client.BaseAddress = new Uri(BaseUrl);
            //            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //            string url = string.Format("v3/stock/list?apikey=39f3e7c61645193688dd11330fd462c7");
            //            HttpResponseMessage resp = client.GetAsync(url).Result;

            //            if (resp.IsSuccessStatusCode)
            //            {
            //                var dailyResponse = resp.Content.ReadAsStringAsync().Result;
            //                stockLists = JsonConvert.DeserializeObject<List<StockLists>>(dailyResponse);

            //                stockLists.ForEach(p =>
            //                {
            //                    StockLists stock = new StockLists()
            //                    {
            //                        symbol = p.symbol,
            //                        exchange = p.exchange,
            //                        exchangeShortName = p.exchangeShortName,
            //                        name = p.name,
            //                        price = p.price,
            //                        type = p.type
            //                    };

            //                    context.StockLists.Add(stock);
            //                    context.SaveChanges();

            //                });
            //            }
            //        }
            //    }
            //}

        }
    }
}
