using DLPR.LicensePlateData.Application.Core.Repositories;
using DLPR.LicensePlateData.Infrastructure.Data;
using DLPR.LicensePlateData.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DLPR.LicensePlateData.Infrastructure.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static void Register(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DLPRLicensePlateDbContext>(options =>
                options.UseSqlServer("name=ConnectionStrings:DLPR_LicensePlateData_Db",
                x => x.MigrationsAssembly("MyApp.DbMigrations")));

            services.AddScoped(typeof(IBaseRepositoryAsync<>), typeof(BaseRepositoryAsync<>));
        }

        public static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            var dbContextOptions = serviceProvider.GetRequiredService<DbContextOptions<DLPRLicensePlateDbContext>>();
            using (var dbContext = new DLPRLicensePlateDbContext(dbContextOptions))
            {
                dbContext.Database.Migrate();
            }
        }
    }
}