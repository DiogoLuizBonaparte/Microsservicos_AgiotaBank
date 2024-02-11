using BancoStandard.IdentityServer.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SQLContext>(
        options => options.UseSqlServer("Server=DESKTOP-71URVSU\\SQLEXPRESS;" +
        "Database=bk_emprestimos;Integrated Security=SSPI;" +
        " TrustServerCertificate=true"));


// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
