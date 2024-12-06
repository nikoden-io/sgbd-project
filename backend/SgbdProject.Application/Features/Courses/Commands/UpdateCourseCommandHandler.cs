using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Commands;

public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, Course>
{
    private readonly ICourseRepository _courseRepository;

    public UpdateCourseCommandHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<Course> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
    {
        var existingCourse = await _courseRepository.GetByIdAsync(request.CourseId);
        if (existingCourse == null)
            return null;

        existingCourse.Name = request.Name;
        existingCourse.Description = request.Description;
        existingCourse.RequiresProjector = request.RequiresProjector;
        existingCourse.RequiresAudioSystem = request.RequiresAudioSystem;
        existingCourse.RequiresTouchScreen = request.RequiresTouchScreen;

        await _courseRepository.UpdateAsync(existingCourse);
        return existingCourse;
    }
}