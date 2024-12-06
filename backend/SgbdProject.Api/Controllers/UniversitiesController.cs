using Microsoft.AspNetCore.Mvc;
using SgbdProject.Api.Models;
using SgbdProject.Application.Interfaces;

namespace SgbdProject.Api.Controllers;

[ApiController]
[Route("api/admin/universities")]
public class UniversitiesController : ControllerBase
{
    private readonly IUniversityRepository _universityRepository;

    public UniversitiesController(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var universities = await _universityRepository.GetAllAsync();
        return Ok(new ApiResponse
        {
            Success = true,
            Code = 200,
            Data = universities,
            Message = "Universities retrieved successfully."
        });
    }
}