namespace SgbdProject.Domain.Entities;

public class Course
{
    public Guid CourseId { get; set; }
    public Guid UniversityId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool RequiresProjector { get; set; }
    public bool RequiresAudioSystem { get; set; }
    public bool RequiresTouchScreen { get; set; }

    // Navigation Properties
    public University University { get; set; }
    public ICollection<CourseSite> CourseSites { get; set; }
    public ICollection<CourseGroup> CourseGroups { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
}