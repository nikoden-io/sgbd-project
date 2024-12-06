namespace SgbdProject.Domain.Entities;

public class CourseSite
{
    public Guid CourseSiteId { get; set; }
    public Guid CourseId { get; set; }
    public Guid SiteId { get; set; }

    // Navigation Properties
    public Course Course { get; set; }
    public Site Site { get; set; }
}