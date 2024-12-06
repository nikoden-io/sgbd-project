using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Sites.Commands;

public class UpdateSiteCommandHandler : IRequestHandler<UpdateSiteCommand, Site>
{
    private readonly ISiteRepository _siteRepository;

    public UpdateSiteCommandHandler(ISiteRepository siteRepository)
    {
        _siteRepository = siteRepository;
    }

    public async Task<Site> Handle(UpdateSiteCommand request, CancellationToken cancellationToken)
    {
        var existingSite = await _siteRepository.GetByIdAsync(request.SiteId);
        if (existingSite == null) return null;

        existingSite.Name = request.Name;
        existingSite.Address = request.Address;

        await _siteRepository.UpdateAsync(existingSite);
        return existingSite;
    }
}