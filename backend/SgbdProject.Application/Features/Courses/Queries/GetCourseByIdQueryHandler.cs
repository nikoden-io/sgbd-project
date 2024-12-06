using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Queries;

public class GetCourseByIdQueryHandler : IRequestHandler<GetCourseByIdQuery, Course>
{
    private readonly ICourseRepository _courseRepository;

    public GetCourseByIdQueryHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<Course> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
    {
        return await _courseRepository.GetByIdAsync(request.CourseId);
    }
}