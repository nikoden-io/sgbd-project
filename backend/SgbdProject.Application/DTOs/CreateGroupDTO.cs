using System.ComponentModel.DataAnnotations;

namespace SgbdProject.Application.DTOs;

public class CreateGroupDTO
{
    [Required] public string Name { get; set; }

    [Required] public Guid MainSiteId { get; set; }

    [Required]
    [Range(20, 40, ErrorMessage = "Number of students must be between 20 and 40.")]
    public int NumberOfStudents { get; set; }
}