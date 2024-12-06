namespace SgbdProject.Domain.Entities;

public class Schedule
{
    public Guid ScheduleId { get; set; }
    public Guid CourseId { get; set; }
    public Guid GroupId { get; set; }
    public Guid? ClassroomId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public Guid AcademicYearId { get; set; }

    // Navigation Properties
    public Course Course { get; set; }
    public Group Group { get; set; }
    public Classroom Classroom { get; set; }
    public AcademicYear AcademicYear { get; set; }
}