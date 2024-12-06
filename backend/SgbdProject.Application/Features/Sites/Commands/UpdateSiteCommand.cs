using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Sites.Commands;

public record UpdateSiteCommand(Guid SiteId, string Name, string Address) : IRequest<Site>;