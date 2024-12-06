using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Sites.Queries;

public record GetSiteByIdQuery(Guid SiteId) : IRequest<Site>;