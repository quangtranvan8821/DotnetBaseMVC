using Microsoft.EntityFrameworkCore;
using DotnetBaseMVCApp.Data;
using DotnetBaseMVCApp.Interfaces;
using DotnetBaseMVCApp.Repository;

var builder = WebApplication.CreateBuilder(args);

// connect to mysql
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var services = builder.Services;
services.AddDbContext<DbContext>(options => options.UseSqlServer(connectionString));

// add scoped for Repository
services.AddScoped<IAccountRepository, AccountRepository>();

// Add services to the container.
services.AddControllersWithViews();

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
