namespace SgbdProject.Domain.Entities;

public class Group
{
    private int _numberOfStudents;
    public Guid GroupId { get; set; }
    public Guid UniversityId { get; set; }
    public Guid? MainSiteId { get; set; }
    public string Name { get; set; }

    public int NumberOfStudents
    {
        get => _numberOfStudents;
        set
        {
            if (value < 20 || value > 40)
                throw new ArgumentOutOfRangeException("Number of students must be between 20 and 40.");
            _numberOfStudents = value;
        }
    }

    // Navigation Properties
    public University University { get; set; }
    public Site MainSite { get; set; }
    public ICollection<CourseGroup> CourseGroups { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
}