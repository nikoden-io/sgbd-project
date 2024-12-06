namespace SgbdProject.Domain.Entities;

public class SiteSchedule
{
    public Guid SiteScheduleId { get; set; }
    public Guid SiteId { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    // Navigation Properties
    public Site Site { get; set; }
}