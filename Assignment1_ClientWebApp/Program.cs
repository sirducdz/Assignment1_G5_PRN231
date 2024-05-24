using Microsoft.EntityFrameworkCore;
using ObjectBusiness.Models;

namespace Assignment1_ClientWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<MyStore_G5Context>(options => { options.UseSqlServer(connectionString); });
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
                pattern: "{controller=orders}/{action=Index}/{id?}");

            app.Run();
        }
    }
}