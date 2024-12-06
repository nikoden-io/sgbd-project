using MediatR;
using Microsoft.AspNetCore.Mvc;
using SgbdProject.Api.Models;
using SgbdProject.Application.DTOs;
using SgbdProject.Application.Features.Courses.Commands;
using SgbdProject.Application.Features.Courses.Queries;
using SgbdProject.Application.Features.Groups.Commands;
using SgbdProject.Application.Features.Groups.Queries;
using SgbdProject.Application.Features.Sites.Commands;
using SgbdProject.Application.Features.Sites.Queries;
using SgbdProject.Application.Features.Universities.Commands;
using SgbdProject.Application.Features.Universities.Queries;

namespace SgbdProject.Api.Controllers;

[ApiController]
[Route("api/admin")]
public class AdministrationController : ControllerBase
{
    private readonly IMediator _mediator;

    public AdministrationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    //*  ------------------------- COURSES -------------------------  *//
    [HttpGet("courses")]
    public async Task<IActionResult> GetAllCourses()
    {
        var courses = await _mediator.Send(new GetAllCoursesQuery());
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = courses,
            Message = "Courses retrieved successfully."
        });
    }

    [HttpGet("courses/{id:guid}")]
    public async Task<IActionResult> GetCourseById(Guid id)
    {
        var course = await _mediator.Send(new GetCourseByIdQuery(id));
        if (course == null)
            return NotFound(new ApiResponse { Success = false, Code = 404, Message = "Course not found." });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = course,
            Message = "Course retrieved successfully."
        });
    }

    [HttpPost("courses")]
    public async Task<IActionResult> CreateCourse([FromBody] CreateCourseDTO dto)
    {
        var course = await _mediator.Send(new CreateCourseCommand(
            dto.UniversityId,
            dto.Name,
            dto.Description,
            dto.RequiresProjector,
            dto.RequiresAudioSystem,
            dto.RequiresTouchScreen));

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 201,
            Data = course,
            Message = "Course created successfully."
        });
    }

    [HttpPut("courses/{id:guid}")]
    public async Task<IActionResult> UpdateCourse(Guid id, [FromBody] UpdateCourseDTO dto)
    {
        var updatedCourse = await _mediator.Send(new UpdateCourseCommand(
            id,
            dto.Name,
            dto.Description,
            dto.RequiresProjector,
            dto.RequiresAudioSystem,
            dto.RequiresTouchScreen));

        if (updatedCourse == null)
            return NotFound(new ApiResponse { Success = false, Code = 404, Message = "Course not found." });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = updatedCourse,
            Message = "Course updated successfully."
        });
    }

    [HttpDelete("courses/{id:guid}")]
    public async Task<IActionResult> DeleteCourse(Guid id)
    {
        var deleted = await _mediator.Send(new DeleteCourseCommand(id));
        if (!deleted)
            return NotFound(new ApiResponse { Success = false, Code = 404, Message = "Course not found." });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = null,
            Message = "Course deleted successfully."
        });
    }


    //*  ------------------------- GROUPS -------------------------  *//
    [HttpGet("groups")]
    public async Task<IActionResult> GetAllGroups()
    {
        var groups = await _mediator.Send(new GetAllGroupsQuery());
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = groups,
            Message = "Groups retrieved successfully."
        });
    }

    [HttpGet("groups/{id:guid}")]
    public async Task<IActionResult> GetGroupById(Guid id)
    {
        var group = await _mediator.Send(new GetGroupByIdQuery(id));
        if (group == null)
            return NotFound(new ApiResponse { Success = false, Code = 404, Message = "Group not found." });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = group,
            Message = "Group retrieved successfully."
        });
    }

    [HttpPost("groups")]
    public async Task<IActionResult> CreateGroup([FromBody] CreateGroupDTO dto)
    {
        var group = await _mediator.Send(new CreateGroupCommand(dto.UniversityId, dto.MainSiteId, dto.Name,
            dto.NumberOfStudents));
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 201,
            Data = group,
            Message = "Group created successfully."
        });
    }

    [HttpPut("groups/{id:guid}")]
    public async Task<IActionResult> UpdateGroup(Guid id, [FromBody] UpdateGroupDTO dto)
    {
        var updatedGroup = await _mediator.Send(new UpdateGroupCommand(id, dto.Name, dto.NumberOfStudents));
        if (updatedGroup == null)
            return NotFound(new ApiResponse { Success = false, Code = 404, Message = "Group not found." });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = updatedGroup,
            Message = "Group updated successfully."
        });
    }

    [HttpDelete("groups/{id:guid}")]
    public async Task<IActionResult> DeleteGroup(Guid id)
    {
        var deleted = await _mediator.Send(new DeleteGroupCommand(id));
        if (!deleted)
            return NotFound(new ApiResponse { Success = false, Code = 404, Message = "Group not found." });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = null,
            Message = "Group deleted successfully."
        });
    }

    //*  ------------------------- SITES -------------------------  *//
    [HttpGet("sites")]
    public async Task<IActionResult> GetAllSites()
    {
        var sites = await _mediator.Send(new GetAllSitesQuery());
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = sites,
            Message = "Sites retrieved successfully."
        });
    }

    [HttpGet("sites/{id:guid}")]
    public async Task<IActionResult> GetSiteById(Guid id)
    {
        var site = await _mediator.Send(new GetSiteByIdQuery(id));
        if (site == null)
            return NotFound(new ApiResponse
            {
                Success = false,
                Code = 404,
                Data = null,
                Message = "Site not found."
            });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = site,
            Message = "Site retrieved successfully."
        });
    }

    [HttpPost("sites")]
    public async Task<IActionResult> CreateSite([FromBody] CreateSiteDTO dto)
    {
        var site = await _mediator.Send(new CreateSiteCommand(dto.UniversityId, dto.Name, dto.Address));
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 201,
            Data = site,
            Message = "Site created successfully."
        });
    }

    [HttpPut("sites/{id:guid}")]
    public async Task<IActionResult> UpdateSite(Guid id, [FromBody] UpdateSiteDTO dto)
    {
        var updatedSite = await _mediator.Send(new UpdateSiteCommand(id, dto.Name, dto.Address));
        if (updatedSite == null)
            return NotFound(new ApiResponse
            {
                Success = false,
                Code = 404,
                Data = null,
                Message = "Site not found."
            });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = updatedSite,
            Message = "Site updated successfully."
        });
    }

    [HttpDelete("sites/{id:guid}")]
    public async Task<IActionResult> DeleteSite(Guid id)
    {
        var deleted = await _mediator.Send(new DeleteSiteCommand(id));
        if (!deleted)
            return NotFound(new ApiResponse
            {
                Success = false,
                Code = 404,
                Data = null,
                Message = "Site not found."
            });

        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = null,
            Message = "Site deleted successfully."
        });
    }

    //* ------------------------- UNIVERSITY  ------------------------- *//
    [HttpGet("universities")]
    public async Task<IActionResult> GetAllUniversities()
    {
        var universities = await _mediator.Send(new GetAllUniversitiesQuery());
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = universities,
            Message = "Universities retrieved successfully."
        });
    }

    [HttpPost("universities")]
    public async Task<IActionResult> CreateUniversity([FromBody] CreateUniversityDTO dto)
    {
        var university = await _mediator.Send(new CreateUniversityCommand(dto.Name, dto.Address));
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 201,
            Data = university,
            Message = "University created successfully."
        });
    }
}

public class CreateUniversityDTO
{
    public string Name { get; set; }
    public string Address { get; set; }
}