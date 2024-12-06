using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Groups.Commands;

public record CreateGroupCommand(Guid UniversityId, Guid MainSiteId, string Name, int NumberOfStudents)
    : IRequest<Group>;