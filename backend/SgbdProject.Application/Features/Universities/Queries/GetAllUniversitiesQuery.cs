using MediatR;
using SgbdProject.Application.DTOs;

namespace SgbdProject.Application.Features.Universities.Queries;

public record GetAllUniversitiesQuery : IRequest<IEnumerable<UniversityDTO>>;