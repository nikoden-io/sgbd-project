using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Queries;

public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, IEnumerable<Course>>
{
    private readonly ICourseRepository _courseRepository;

    public GetAllCoursesQueryHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<IEnumerable<Course>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
    {
        return await _courseRepository.GetAllAsync();
    }
}