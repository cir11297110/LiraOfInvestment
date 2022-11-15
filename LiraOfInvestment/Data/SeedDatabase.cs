using LiraOfInvestment.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace LiraOfInvestment.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StockContext(
                serviceProvider.GetRequiredService<DbContextOptions<StockContext>>()))
            {
                //context.Database.EnsureCreated();

                List<StockList> stockLists = new List<StockList>();
                if (!context.StockLists.Any())
                {


                    using (var client = new HttpClient())
                    {
                        string BaseUrl = "https://financialmodelingprep.com/api/";
                        client.BaseAddress = new Uri(BaseUrl);
                        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                        string url = string.Format("v3/stock/list?apikey=39f3e7c61645193688dd11330fd462c7");
                        HttpResponseMessage resp = client.GetAsync(url).Result;

                        if (resp.IsSuccessStatusCode)
                        {
                            var dailyResponse = resp.Content.ReadAsStringAsync().Result;
                            stockLists = JsonConvert.DeserializeObject<List<StockList>>(dailyResponse);

                            stockLists.ForEach(p =>
                            {
                                StockList stock = new StockList()
                                {
                                    symbol = p.symbol,
                                    exchange = p.exchange,
                                    exchangeShortName = p.exchangeShortName,
                                    name = p.name,
                                    price = p.price,
                                    type = p.type
                                };

                                context.StockLists.Add(stock);
                                context.SaveChanges();

                            });
                        }
                    }
                }
            }

        }
    }
}
