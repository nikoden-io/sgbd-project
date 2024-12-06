using MediatR;
using SgbdProject.Application.Interfaces;

namespace SgbdProject.Application.Features.Courses.Commands;

public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, bool>
{
    private readonly ICourseRepository _courseRepository;

    public DeleteCourseCommandHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<bool> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
    {
        var existingCourse = await _courseRepository.GetByIdAsync(request.CourseId);
        if (existingCourse == null)
            return false;

        await _courseRepository.DeleteAsync(request.CourseId);
        return true;
    }
}