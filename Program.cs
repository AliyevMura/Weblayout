using Microsoft.PowerBI.Api.Models;

namespace WebTaskLayout
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           //builder.Services.AddControllersWithViews
           // var app = builder.Build();
           builder.Services.AddControllersWithViews();
            var app= builder.Build();
            //app.MapGet("/", () => "Hello World!");
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

       
            app.Run();
        }
    }
}