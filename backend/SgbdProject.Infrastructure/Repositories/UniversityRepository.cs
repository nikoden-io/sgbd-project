using Microsoft.EntityFrameworkCore;
using SgbdProject.Application.DTOs;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Infrastructure.Repositories;

public class UniversityRepository : IUniversityRepository
{
    private readonly ApplicationDbContext _context;

    public UniversityRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsAsync(Guid universityId)
    {
        return await _context.Universities.AnyAsync(u => u.UniversityId == universityId);
    }

    public async Task<UniversityDTO> GetByIdAsync(Guid id)
    {
        var university = await _context.Universities
            .Include(u => u.Sites)
            .FirstOrDefaultAsync(u => u.UniversityId == id);

        if (university == null) return null;

        return new UniversityDTO
        {
            UniversityId = university.UniversityId,
            Name = university.Name,
            Address = university.Address,
            Sites = university.Sites.Select(s => new SiteDto
            {
                SiteId = s.SiteId,
                Name = s.Name,
                Address = s.Address
            }).ToList()
        };
    }

    public async Task<IEnumerable<UniversityDTO>> GetAllAsync()
    {
        var universities = await _context.Universities
            .Include(u => u.Sites)
            .ToListAsync();

        return universities.Select(u => new UniversityDTO
        {
            UniversityId = u.UniversityId,
            Name = u.Name,
            Address = u.Address,
            Sites = u.Sites.Select(s => new SiteDto
            {
                SiteId = s.SiteId,
                Name = s.Name,
                Address = s.Address
            }).ToList()
        }).ToList();
    }

    public async Task AddAsync(University university)
    {
        await _context.Universities.AddAsync(university);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(University university)
    {
        _context.Universities.Update(university);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var university = await _context.Universities.FindAsync(id);
        if (university != null)
        {
            _context.Universities.Remove(university);
            await _context.SaveChangesAsync();
        }
    }
}