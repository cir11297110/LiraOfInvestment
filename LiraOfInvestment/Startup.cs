using Azure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace LiraOfInvestment
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("AzureDatabase");
            services.AddTransient(a =>
            {
                var sqlConnection = new SqlConnection(connectionString);
                var credential = new DefaultAzureCredential();
                var token = credential
                        .GetToken(new Azure.Core.TokenRequestContext(
                            new[] { "https://database.windows.net/.default" }));
                sqlConnection.AccessToken = token.Token;
                return sqlConnection;
            });
    }   }
}
