namespace SgbdProject.Application.DTOs;

public class ScheduleDTO
{
    public Guid ScheduleId { get; set; }
    public Guid CourseId { get; set; }
    public Guid GroupId { get; set; }
    public Guid ClassroomId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}