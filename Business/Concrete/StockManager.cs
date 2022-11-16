using Business.Abstract;

using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StockManager : IStockService
    {
        private IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public List<Stock> GetAll()
        {
            return _stockDal.GetList();
        }

        public List<Stock> GetBySymbol(string symbol)
        {
            return _stockDal.GetList(p => p.symbol == symbol);
        }
    }
}
