using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Courses.Queries;

public record GetAllCoursesQuery : IRequest<IEnumerable<Course>>;