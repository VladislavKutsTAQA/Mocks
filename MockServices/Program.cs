using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MockServices.Idp.Requests;
using MockServices.Options;
using Refit;
using Serilog;

namespace MockServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseSerilog()
                .ConfigureServices((hostContext, services) => ConfigureServices(services, hostContext.Configuration));
        
        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var idp = configuration.GetSection("Idp");
            var uri = configuration.GetSection("Idp:Uri");
            services
                .Configure<IdpOptions>(configuration.GetSection("Idp"))
                .AddSingleton<IdpWrapper>()
                .AddRefitClient<IIdp>()
                .ConfigureHttpClient(c =>
                    c.BaseAddress = new Uri(configuration.GetSection("Idp:Uri").Value)
                );
        }
    }
}