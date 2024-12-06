namespace SgbdProject.Application.DTOs;

public class UpdateCourseDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool RequiresProjector { get; set; }
    public bool RequiresAudioSystem { get; set; }
    public bool RequiresTouchScreen { get; set; }
}