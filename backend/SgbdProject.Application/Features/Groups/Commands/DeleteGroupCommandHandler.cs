using MediatR;
using SgbdProject.Application.Interfaces;

namespace SgbdProject.Application.Features.Groups.Commands;

public class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommand, bool>
{
    private readonly IGroupRepository _groupRepository;

    public DeleteGroupCommandHandler(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public async Task<bool> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
    {
        var existingGroup = await _groupRepository.GetByIdAsync(request.GroupId);
        if (existingGroup == null)
            return false;

        await _groupRepository.DeleteAsync(request.GroupId);
        return true;
    }
}