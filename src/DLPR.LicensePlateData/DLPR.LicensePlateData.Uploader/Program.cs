using DLPR.LicensePlateData.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DLPR.LicensePlateData.Uploader
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            Infrastructure.DependencyResolver.DependencyResolverService.Register(builder.Services, builder.Configuration);

            var host = builder.Build();


            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<DLPRLicensePlateDbContext>();

                var curPlates = dbContext.LicensePlates.ToList();
            }


        }
    }
}