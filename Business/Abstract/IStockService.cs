
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAll();
        List<Stock> GetBySymbol(string symbol);
        StockDetail GetDetail(string symbol);
        
    }
}
