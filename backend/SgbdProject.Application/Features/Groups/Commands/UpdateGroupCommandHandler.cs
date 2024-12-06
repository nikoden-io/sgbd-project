using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Groups.Commands;

public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand, Group>
{
    private readonly IGroupRepository _groupRepository;

    public UpdateGroupCommandHandler(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public async Task<Group> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
    {
        var existingGroup = await _groupRepository.GetByIdAsync(request.GroupId);
        if (existingGroup == null)
            return null;

        if (request.NumberOfStudents < 20 || request.NumberOfStudents > 40)
            throw new ArgumentException("Number of students must be between 20 and 40.");

        existingGroup.Name = request.Name;
        existingGroup.NumberOfStudents = request.NumberOfStudents;

        await _groupRepository.UpdateAsync(existingGroup);
        return existingGroup;
    }
}