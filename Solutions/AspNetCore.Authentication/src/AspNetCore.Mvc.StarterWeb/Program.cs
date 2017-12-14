using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Net;
using System;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.StarterWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();        
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IWebHostBuilder webHostBuilder = WebHost.CreateDefaultBuilder(args)
                .UseAzureAppServices()
                ////})
                ////.UseUrls("https://localhost:5000")
                .UseStartup<Startup>();

            return webHostBuilder.Build();
        }
    }
}