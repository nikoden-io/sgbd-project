using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Groups.Queries;

public record GetGroupByIdQuery(Guid GroupId) : IRequest<Group>;