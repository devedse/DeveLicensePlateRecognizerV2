using DLPR.LicensePlateData.Domain.Core.Models;

namespace DLPR.LicensePlateData.Application.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task RollBackChangesAsync();
        IBaseRepositoryAsync<T> Repository<T>() where T : BaseEntity;
    }
}