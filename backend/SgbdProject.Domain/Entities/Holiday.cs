namespace SgbdProject.Domain.Entities;

public class Holiday
{
    public Guid HolidayId { get; set; }
    public Guid SiteId { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    // Navigation Properties
    public Site Site { get; set; }
}