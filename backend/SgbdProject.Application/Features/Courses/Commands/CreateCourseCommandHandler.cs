using MediatR;
using SgbdProject.Application.Interfaces;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Commands;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Course>
{
    private readonly ICourseRepository _courseRepository;
    private readonly IUniversityRepository _universityRepository;

    public CreateCourseCommandHandler(ICourseRepository courseRepository, IUniversityRepository universityRepository)
    {
        _courseRepository = courseRepository;
        _universityRepository = universityRepository;
    }

    public async Task<Course> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var universityExists = await _universityRepository.ExistsAsync(request.UniversityId);
        if (!universityExists)
            throw new ArgumentException($"University with ID {request.UniversityId} does not exist.");

        var course = new Course
        {
            CourseId = Guid.NewGuid(),
            UniversityId = request.UniversityId,
            Name = request.Name,
            Description = request.Description,
            RequiresProjector = request.RequiresProjector,
            RequiresAudioSystem = request.RequiresAudioSystem,
            RequiresTouchScreen = request.RequiresTouchScreen
        };

        await _courseRepository.AddAsync(course);
        return course;
    }
}