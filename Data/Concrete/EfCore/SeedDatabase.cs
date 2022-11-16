using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Data.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
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
