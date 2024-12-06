namespace SgbdProject.Domain.Entities;

public class Site
{
    public Guid SiteId { get; set; }
    public Guid UniversityId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    // Existing Navigation Properties
    public University University { get; set; }
    public ICollection<Classroom> Classrooms { get; set; }
    public ICollection<SiteSchedule> SiteSchedules { get; set; }
    public ICollection<Holiday> Holidays { get; set; }
    public ICollection<CourseSite> CourseSites { get; set; }
}