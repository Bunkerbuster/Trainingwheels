using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CommanderGQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // Door dat we de IHostBuilder gebruiken, worden de volgende 3 services 
        // automatisch geinjecteerd 
        // IWebHostEnvironment
        // IhostEnvironment
        // IConfiguration
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
