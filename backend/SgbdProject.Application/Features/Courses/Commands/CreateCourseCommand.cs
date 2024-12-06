using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Commands;

public record CreateCourseCommand(
    Guid UniversityId,
    string Name,
    string Description,
    bool RequiresProjector,
    bool RequiresAudioSystem,
    bool RequiresTouchScreen) : IRequest<Course>;