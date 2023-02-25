using DLPR.LicensePlateData.Application.Interfaces;
using DLPR.LicensePlateData.Application.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DLPR.LicensePlateData.Application.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<ILicensePlateService, LicensePlateService>();
        }
    }
}