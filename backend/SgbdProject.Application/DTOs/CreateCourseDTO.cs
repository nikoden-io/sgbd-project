using System.ComponentModel.DataAnnotations;

namespace SgbdProject.Application.DTOs;

public class CreateCourseDTO
{
    [Required] public string Name { get; set; }

    public string Description { get; set; }
    public bool RequiresProjector { get; set; }
    public bool RequiresAudioSystem { get; set; }
    public bool RequiresTouchScreen { get; set; }
}