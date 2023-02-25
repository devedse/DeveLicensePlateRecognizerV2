using DLPR.LicensePlateData.Application.Core.Repositories;
using DLPR.LicensePlateData.Application.Interfaces;
using DLPR.LicensePlateData.Domain.Entities;
using DLPR.LicensePlateData.Domain.Specifications;
using Microsoft.Extensions.Logging;

namespace DLPR.LicensePlateData.Application.Service
{
    public class LicensePlateService : ILicensePlateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<LicensePlateService> _logger;

        public LicensePlateService(IUnitOfWork unitOfWork, ILogger<LicensePlateService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<LicensePlate?> GetLicensePlateByKey(string licensePlateText)
        {
            var activeUsersSpec = LicensePlateSpecification.GetLicensePlateByKey(licensePlateText);
            var licensePlate = await _unitOfWork.Repository<LicensePlate>().FirstOrDefaultAsync(activeUsersSpec);

            return licensePlate;
        }
    }
}
