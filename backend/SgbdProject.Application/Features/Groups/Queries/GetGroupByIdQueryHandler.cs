using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Groups.Queries;

public class GetGroupByIdQueryHandler : IRequestHandler<GetGroupByIdQuery, Group>
{
    private readonly IGroupRepository _groupRepository;

    public GetGroupByIdQueryHandler(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public async Task<Group> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
    {
        return await _groupRepository.GetByIdAsync(request.GroupId);
    }
}