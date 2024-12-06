using MediatR;

namespace SgbdProject.Application.Features.Sites.Commands;

public record DeleteSiteCommand(Guid SiteId) : IRequest<bool>;