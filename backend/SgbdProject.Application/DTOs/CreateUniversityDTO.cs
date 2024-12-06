using System.ComponentModel.DataAnnotations;

namespace SgbdProject.Application.DTOs;

public class CreateUniversityDTO
{
    [Required] public string Name { get; set; }

    [Required] public string Address { get; set; }
}