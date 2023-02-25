using DLPR.LicensePlateData.Domain.Entities;

namespace DLPR.LicensePlateData.Application.Interfaces
{
    public interface ILicensePlateService
    {
        Task<LicensePlate?> GetLicensePlateByKey(string licensePlateText);
    }
}