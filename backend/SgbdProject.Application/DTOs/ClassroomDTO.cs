namespace SgbdProject.Application.DTOs;

public class ClassroomDTO
{
    public Guid ClassroomId { get; set; }
    public Guid SiteId { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public bool HasProjector { get; set; }
    public bool HasAudioSystem { get; set; }
    public bool HasTouchScreen { get; set; }
}