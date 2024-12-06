namespace SgbdProject.Domain.Entities;

public class CourseGroup
{
    public Guid CourseGroupId { get; set; }
    public Guid CourseId { get; set; }
    public Guid GroupId { get; set; }
    public Guid AcademicYearId { get; set; }

    // Navigation Properties
    public Course Course { get; set; }
    public Group Group { get; set; }
    public AcademicYear AcademicYear { get; set; }
}