using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Interfaces;

public interface IUniversityRepository
{
    Task<IEnumerable<University>> GetAllAsync();
    Task<University> GetByIdAsync(Guid id);
    Task AddAsync(University university);
    Task UpdateAsync(University university);
    Task DeleteAsync(Guid id);
}