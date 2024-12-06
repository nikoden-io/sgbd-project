namespace SgbdProject.Application.DTOs;

public class GroupDTO
{
    public Guid GroupId { get; set; }
    public Guid UniversityId { get; set; }
    public Guid MainSiteId { get; set; }
    public string Name { get; set; }
    public int NumberOfStudents { get; set; }
}