namespace SgbdProject.Api.Models;

public class ApiResponse
{
    public bool Success { get; set; }
    public int Code { get; set; }
    public object Data { get; set; }
    public string Message { get; set; }
}