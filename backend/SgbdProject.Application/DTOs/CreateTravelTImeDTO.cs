using System.ComponentModel.DataAnnotations;

namespace SgbdProject.Application.DTOs;

public class CreateTravelTImeDTO
{
    [Required] public Guid FromSiteId { get; set; }

    [Required] public Guid ToSiteId { get; set; }

    [Required] public int DurationInMinutes { get; set; }
}