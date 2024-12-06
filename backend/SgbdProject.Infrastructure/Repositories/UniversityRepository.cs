using Microsoft.EntityFrameworkCore;
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

    public async Task<IEnumerable<University>> GetAllAsync()
    {
        return await _context.Universities.ToListAsync();
    }

    public async Task<University> GetByIdAsync(Guid id)
    {
        return await _context.Universities.FindAsync(id);
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