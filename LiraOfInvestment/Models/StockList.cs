using System.ComponentModel.DataAnnotations;

namespace LiraOfInvestment.Models
{
    public class StockList
    {
        [Key]
        public string symbol { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string exchange { get; set; }
        public string exchangeShortName { get; set; }
        public string type { get; set; }
    }
}
