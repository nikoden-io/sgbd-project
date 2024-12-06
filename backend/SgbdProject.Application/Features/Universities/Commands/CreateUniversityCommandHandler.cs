using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Universities.Commands;

public class CreateUniversityCommandHandler : IRequestHandler<CreateUniversityCommand, University>
{
    private readonly IUniversityRepository _universityRepository;

    public CreateUniversityCommandHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task<University> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
    {
        var university = new University
        {
            UniversityId = Guid.NewGuid(),
            Name = request.Name,
            Address = request.Address
        };
        await _universityRepository.AddAsync(university);
        return university;
    }
}