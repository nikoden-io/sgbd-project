using MediatR;
using SgbdProject.Application.DTOs;
using SgbdProject.Application.Interfaces;

namespace SgbdProject.Application.Features.Universities.Queries;

public class GetAllUniversitiesQueryHandler : IRequestHandler<GetAllUniversitiesQuery, IEnumerable<UniversityDTO>>
{
    private readonly IUniversityRepository _universityRepository;

    public GetAllUniversitiesQueryHandler(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public async Task<IEnumerable<UniversityDTO>> Handle(GetAllUniversitiesQuery request,
        CancellationToken cancellationToken)
    {
        return await _universityRepository.GetAllAsync();
    }
}