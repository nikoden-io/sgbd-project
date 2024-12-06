using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Interfaces;

public interface ISiteRepository
{
    Task<bool> ExistsAsync(Guid siteId);
    Task<IEnumerable<Site>> GetAllAsync();
    Task<Site> GetByIdAsync(Guid id);
    Task AddAsync(Site site);
    Task UpdateAsync(Site site);
    Task DeleteAsync(Guid id);
}