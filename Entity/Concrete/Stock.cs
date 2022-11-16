
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Stock:IEntity
    {
        [Key]
        public string? symbol { get; set; }
        public string? name { get; set; }
        public double? price { get; set; }
        public string? exchange { get; set; }
        public string? exchangeShortName { get; set; }
        public string? type { get; set; }
    }
}
