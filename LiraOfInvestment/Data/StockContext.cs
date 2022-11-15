using LiraOfInvestment.Models;
using Microsoft.EntityFrameworkCore;

namespace LiraOfInvestment.Data
{
    public class StockContext:DbContext
    {
        public StockContext(DbContextOptions<StockContext> options)
        : base(options)
        {

        }
        public DbSet<StockList> StockLists { get; set; }
    }
}
