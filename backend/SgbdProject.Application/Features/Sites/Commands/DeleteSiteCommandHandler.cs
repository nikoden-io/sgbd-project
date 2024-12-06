using MediatR;
using SgbdProject.Application.Interfaces;

namespace SgbdProject.Application.Features.Sites.Commands;

public class DeleteSiteCommandHandler : IRequestHandler<DeleteSiteCommand, bool>
{
    private readonly ISiteRepository _siteRepository;

    public DeleteSiteCommandHandler(ISiteRepository siteRepository)
    {
        _siteRepository = siteRepository;
    }

    public async Task<bool> Handle(DeleteSiteCommand request, CancellationToken cancellationToken)
    {
        var existingSite = await _siteRepository.GetByIdAsync(request.SiteId);
        if (existingSite == null)
            return false;

        await _siteRepository.DeleteAsync(request.SiteId);
        return true;
    }
}