using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Sites.Queries;

public class GetAllSitesQueryHandler : IRequestHandler<GetAllSitesQuery, IEnumerable<Site>>
{
    private readonly ISiteRepository _siteRepository;

    public GetAllSitesQueryHandler(ISiteRepository siteRepository)
    {
        _siteRepository = siteRepository;
    }

    public async Task<IEnumerable<Site>> Handle(GetAllSitesQuery request, CancellationToken cancellationToken)
    {
        return await _siteRepository.GetAllAsync();
    }
}