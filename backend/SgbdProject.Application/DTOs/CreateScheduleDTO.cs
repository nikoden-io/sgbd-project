using System.ComponentModel.DataAnnotations;

namespace SgbdProject.Application.DTOs;

public class CreateScheduleDTO
{
    [Required] public Guid CourseId { get; set; }

    [Required] public Guid GroupId { get; set; }

    [Required] public Guid ClassroomId { get; set; }

    [Required] public DateTime Date { get; set; }

    [Required] public TimeSpan StartTime { get; set; }

    [Required] public TimeSpan EndTime { get; set; }
}