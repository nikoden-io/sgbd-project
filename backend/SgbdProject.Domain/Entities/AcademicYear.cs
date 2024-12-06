namespace SgbdProject.Domain.Entities;

public class AcademicYear
{
    public Guid AcademicYearId { get; set; }
    public Guid UniversityId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Navigation Properties
    public University University { get; set; }
    public ICollection<CourseGroup> CourseGroups { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
}