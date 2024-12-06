using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Groups.Commands;

public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, Group>
{
    private readonly IGroupRepository _groupRepository;
    private readonly ISiteRepository _siteRepository;
    private readonly IUniversityRepository _universityRepository;

    public CreateGroupCommandHandler(
        IGroupRepository groupRepository,
        IUniversityRepository universityRepository,
        ISiteRepository siteRepository)
    {
        _groupRepository = groupRepository;
        _universityRepository = universityRepository;
        _siteRepository = siteRepository;
    }

    public async Task<Group> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
    {
        var universityExists = await _universityRepository.ExistsAsync(request.UniversityId);
        if (!universityExists)
            throw new ArgumentException($"University with ID {request.UniversityId} does not exist.");

        var siteExists = await _siteRepository.ExistsAsync(request.MainSiteId);
        if (!siteExists)
            throw new ArgumentException(
                $"Site with ID {request.MainSiteId} does not exist in the specified University.");

        if (request.NumberOfStudents < 20 || request.NumberOfStudents > 40)
            throw new ArgumentException("Number of students must be between 20 and 40.");

        var group = new Group
        {
            GroupId = Guid.NewGuid(),
            UniversityId = request.UniversityId,
            MainSiteId = request.MainSiteId,
            Name = request.Name,
            NumberOfStudents = request.NumberOfStudents
        };

        await _groupRepository.AddAsync(group);
        return group;
    }
}