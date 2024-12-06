using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Sites.Commands;

public class CreateSiteCommandHandler : IRequestHandler<CreateSiteCommand, Site>
{
    private readonly ISiteRepository _siteRepository;
    private readonly IUniversityRepository _universityRepository;

    public CreateSiteCommandHandler(ISiteRepository siteRepository, IUniversityRepository universityRepository)
    {
        _siteRepository = siteRepository;
        _universityRepository = universityRepository;
    }

    public async Task<Site> Handle(CreateSiteCommand request, CancellationToken cancellationToken)
    {
        // Validate the UniversityId
        var universityExists = await _universityRepository.ExistsAsync(request.UniversityId);
        if (!universityExists)
            throw new ArgumentException($"University with ID {request.UniversityId} does not exist.");

        // Proceed with creating the site
        var site = new Site
        {
            SiteId = Guid.NewGuid(),
            UniversityId = request.UniversityId,
            Name = request.Name,
            Address = request.Address
        };

        await _siteRepository.AddAsync(site);
        return site;
    }
}