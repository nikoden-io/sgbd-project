namespace SgbdProject.Application.DTOs;

public class TravelTimeDTO
{
    public Guid TravelTimeId { get; set; }
    public Guid FromSiteId { get; set; }
    public Guid ToSiteId { get; set; }
    public int DurationInMinutes { get; set; }
}