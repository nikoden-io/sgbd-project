using MediatR;
using SgbdProject.Domain.Entities;

namespace SgbdProject.Application.Features.Sites.Commands;

public record CreateSiteCommand(Guid UniversityId, string Name, string Address) : IRequest<Site>;