using BooksApp_Sec02.Data;
using Microsoft.EntityFrameworkCore;

namespace BooksApp_Sec02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //get connection string information and store it in a variable
            var connectionString = builder.Configuration.GetConnectionString("BooksDBConnection");

            //add the DbContext class to the services using sqlserver as the default DBMS, along with the connection string fetched in the previous stmt
            builder.Services.AddDbContext<BooksDBContext>(options => options.UseSqlServer(connectionString));




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
        }
    }
}