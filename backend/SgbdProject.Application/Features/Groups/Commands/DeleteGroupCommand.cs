using MediatR;

namespace SgbdProject.Application.Features.Groups.Commands;

public record DeleteGroupCommand(Guid GroupId) : IRequest<bool>;