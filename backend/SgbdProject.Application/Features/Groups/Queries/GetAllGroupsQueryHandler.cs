using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Groups.Queries;

public class GetAllGroupsQueryHandler : IRequestHandler<GetAllGroupsQuery, IEnumerable<Group>>
{
    private readonly IGroupRepository _groupRepository;

    public GetAllGroupsQueryHandler(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public async Task<IEnumerable<Group>> Handle(GetAllGroupsQuery request, CancellationToken cancellationToken)
    {
        return await _groupRepository.GetAllAsync();
    }
}