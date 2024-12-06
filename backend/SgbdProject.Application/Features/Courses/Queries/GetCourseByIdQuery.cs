using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Queries;

public record GetCourseByIdQuery(Guid CourseId) : IRequest<Course>;