using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Universities.Commands;

public record CreateUniversityCommand(string Name, string Address) : IRequest<University>;