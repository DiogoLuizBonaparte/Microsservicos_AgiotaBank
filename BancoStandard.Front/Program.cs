using BancoStandard.Front.Services;
using BancoStandard.Front.Services.IServices;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IClientService, ClientService>( c =>
    c.BaseAddress = new Uri(builder.Configuration["ServiceUrls:ClienteAPI"])
    );

builder.Services.AddHttpClient<IContractService, ContractService>(c =>
    c.BaseAddress = new Uri(builder.Configuration["ServiceUrls:ContractAPI"])
    );


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
