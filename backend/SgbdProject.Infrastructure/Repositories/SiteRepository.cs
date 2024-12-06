using Microsoft.EntityFrameworkCore;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Infrastructure.Repositories;

public class SiteRepository : ISiteRepository
{
    private readonly ApplicationDbContext _context;

    public SiteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsAsync(Guid siteId)
    {
        return await _context.Sites.AnyAsync(s => s.SiteId == siteId);
    }

    public async Task<IEnumerable<Site>> GetAllAsync()
    {
        return await _context.Sites.ToListAsync();
    }

    public async Task<Site> GetByIdAsync(Guid id)
    {
        return await _context.Sites.FindAsync(id);
    }

    public async Task AddAsync(Site site)
    {
        await _context.Sites.AddAsync(site);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Site site)
    {
        _context.Sites.Update(site);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var site = await _context.Sites.FindAsync(id);
        if (site != null)
        {
            _context.Sites.Remove(site);
            await _context.SaveChangesAsync();
        }
    }
}