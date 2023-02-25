using DLPR.LicensePlateData.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DLPR.LicensePlateData.Infrastructure.Data
{
    public class DLPRLicensePlateDbContext : DbContext
    {
        public virtual DbSet<LicensePlate> LicensePlates => Set<LicensePlate>();

        public DLPRLicensePlateDbContext(DbContextOptions<DLPRLicensePlateDbContext> options) : base(options)
        {
        }
    }
}
