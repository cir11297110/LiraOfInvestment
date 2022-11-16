using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Data.Abstract;
using Data.Concrete.EfCore;


using LiraOfInvestment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<StockContext>(options => {
//    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureDatabase"));
//});

// Add services to the container.

//builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
//{
//    builder.RegisterModule(new AutoFacBusinessModule());
//});


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IStockDal, EfCoreStockDal>();

builder.Services.AddTransient<IStockService, StockManager>();


builder.Services.AddSession();

var app = builder.Build();




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
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
