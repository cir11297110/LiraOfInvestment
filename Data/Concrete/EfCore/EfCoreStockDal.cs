
using Core.DataAccess.Concrete.EntityFramework;
using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EfCore
{
    public class EfCoreStockDal :EfEntityRepositoryBase<Stock,StockContext>, IStockDal
    {
        
    }
}
