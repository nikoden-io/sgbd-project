using SgbdProject.Application.DTOs;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Interfaces;

public interface IUniversityRepository
{
    Task<bool> ExistsAsync(Guid universityId);
    Task<IEnumerable<UniversityDTO>> GetAllAsync();
    Task<UniversityDTO> GetByIdAsync(Guid id);
    Task AddAsync(University university);
    Task UpdateAsync(University university);
    Task DeleteAsync(Guid id);
}