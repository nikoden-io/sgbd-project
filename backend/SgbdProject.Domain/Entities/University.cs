namespace SgbdProject.Domain.Entities;

public class University
{
    public Guid UniversityId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    // Navigation Properties
    public ICollection<Site> Sites { get; set; }
    public ICollection<Course> Courses { get; set; }
    public ICollection<Group> Groups { get; set; }
    public ICollection<AcademicYear> AcademicYears { get; set; }
}