using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Commands;

public record UpdateCourseCommand(
    Guid CourseId,
    string Name,
    string Description,
    bool RequiresProjector,
    bool RequiresAudioSystem,
    bool RequiresTouchScreen) : IRequest<Course>;