using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Sites.Queries;

public class GetSiteByIdQueryHandler : IRequestHandler<GetSiteByIdQuery, Site>
{
    private readonly ISiteRepository _siteRepository;

    public GetSiteByIdQueryHandler(ISiteRepository siteRepository)
    {
        _siteRepository = siteRepository;
    }

    public async Task<Site> Handle(GetSiteByIdQuery request, CancellationToken cancellationToken)
    {
        return await _siteRepository.GetByIdAsync(request.SiteId);
    }
}