using System.ComponentModel.DataAnnotations;

namespace SgbdProject.Application.DTOs;

public class CreateClassroomDTO
{
    [Required]
    public string Name { get; set; }

    [Required]
    public int Capacity { get; set; }

    public bool HasProjector { get; set; }
    public bool HasAudioSystem { get; set; }
    public bool HasTouchScreen { get; set; }
}