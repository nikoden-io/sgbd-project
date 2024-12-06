namespace SgbdProject.Domain.Entities;

public class TravelTime
{
    public Guid TravelTimeId { get; set; }
    public Guid? FromSiteId { get; set; }
    public Guid? ToSiteId { get; set; }
    public int DurationInMinutes { get; set; }

    // Navigation Properties
    public Site FromSite { get; set; }
    public Site ToSite { get; set; }
}