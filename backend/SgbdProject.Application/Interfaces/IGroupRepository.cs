using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Interfaces;

public interface IGroupRepository
{
    Task<bool> ExistsAsync(Guid groupId);
    Task<IEnumerable<Group>> GetAllAsync();
    Task<Group> GetByIdAsync(Guid id);
    Task AddAsync(Group group);
    Task UpdateAsync(Group group);
    Task DeleteAsync(Guid id);
}