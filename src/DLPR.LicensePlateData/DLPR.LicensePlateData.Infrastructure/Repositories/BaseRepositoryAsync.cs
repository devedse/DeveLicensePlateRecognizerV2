using DLPR.LicensePlateData.Application.Core.Repositories;
using DLPR.LicensePlateData.Domain.Core.Models;
using DLPR.LicensePlateData.Domain.Core.Specifications;
using DLPR.LicensePlateData.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DLPR.LicensePlateData.Infrastructure.Repositories
{
    public class BaseRepositoryAsync<T> : IBaseRepositoryAsync<T> where T : BaseEntity
    {
        protected readonly DLPRLicensePlateDbContext _dbContext;

        public BaseRepositoryAsync(DLPRLicensePlateDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<T> FirstOrDefaultAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }
    }
}
