using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Groups.Commands;

public record UpdateGroupCommand(Guid GroupId, string Name, int NumberOfStudents) : IRequest<Group>;