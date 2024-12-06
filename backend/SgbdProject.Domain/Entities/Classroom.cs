namespace SgbdProject.Domain.Entities;

public class Classroom
{
    public Guid ClassroomId { get; set; }
    public Guid SiteId { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public bool HasProjector { get; set; }
    public bool HasAudioSystem { get; set; }
    public bool HasTouchScreen { get; set; }

    // Navigation Properties
    public Site Site { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
}