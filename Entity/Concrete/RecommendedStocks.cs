using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{


    public class RecommendedStocks
    {
        public Finance finance { get; set; }
    }

    public class Finance
    {
        public Result[] result { get; set; }
        public object error { get; set; }
    }

    public class Result
    {
        public int count { get; set; }
        public Quote[] quotes { get; set; }
    }

    public class Quote
    {
        public string language { get; set; }
        public string region { get; set; }
        public string quoteType { get; set; }
        public bool triggerable { get; set; }
        public string quoteSourceName { get; set; }
        public string exchange { get; set; }
        public string market { get; set; }
        public int priceHint { get; set; }
        public bool esgPopulated { get; set; }
        public bool tradeable { get; set; }
        public float preMarketChange { get; set; }
        public float preMarketChangePercent { get; set; }
        public int preMarketTime { get; set; }
        public float preMarketPrice { get; set; }
        public float regularMarketChangePercent { get; set; }
        public float regularMarketPreviousClose { get; set; }
        public string fullExchangeName { get; set; }
        public int sourceInterval { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public int gmtOffSetMilliseconds { get; set; }
        public string shortName { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public string marketState { get; set; }
        public float regularMarketPrice { get; set; }
        public int regularMarketTime { get; set; }
        public float regularMarketChange { get; set; }
        public string symbol { get; set; }
    }

}

