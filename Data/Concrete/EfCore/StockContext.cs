using Entity.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Data.Concrete.EfCore
{
    public class StockContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=lirainvestmentserver.database.windows.net;initial catalog=LiraOfInvestment_DB;User Id=lirainvestment;Password=Lira2022;encrypt=false");
        }
      
        
        public DbSet<Stock> Stocks { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Server=lirainvestmentserver.database.windows.net,1433;Database=LiraOfInvestment_DB;User Id=lirainvestment;Password=Lira2022;trusted_connection=true");
        //    optionsBuilder.UseSqlServer(@"Server=YIGITCAN-DESKTO\\SQLEXPRESS;Database=TermProjectTest;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    //base.OnConfiguring(optionsBuilder);

        //}
    }
}
