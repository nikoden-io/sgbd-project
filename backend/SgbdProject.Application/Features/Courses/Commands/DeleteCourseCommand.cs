using MediatR;

namespace SgbdProject.Application.Features.Courses.Commands;

public record DeleteCourseCommand(Guid CourseId) : IRequest<bool>;