using LiraOfInvestment.Data;
using LiraOfInvestment.Data.Repositories;
using LiraOfInvestment.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StockContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("AzureDatabase"), builder => builder.EnableRetryOnFailure()));
// Add services to the container.
builder.Services.AddHttpClient<StockList>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<StockListRepository>();
var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<StockContext>();



    SeedDatabase.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
