using DLPR.LicensePlateData.Domain.Core.Specifications;
using DLPR.LicensePlateData.Domain.Entities;

namespace DLPR.LicensePlateData.Domain.Specifications
{
    public static class LicensePlateSpecification
    {
        public static BaseSpecification<LicensePlate> GetLicensePlateByKey(string licensePlateText)
        {
            return new BaseSpecification<LicensePlate>(x => x.Kenteken == licensePlateText);
        }

        public static BaseSpecification<LicensePlate> GetAllLicensePlates()
        {
            return new BaseSpecification<LicensePlate>(x => true);
        }
    }
}
