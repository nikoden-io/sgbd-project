using System.Net;
using Newtonsoft.Json;
using SgbdProject.Api.Models;

namespace SgbdProject.Api.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var statusCode = HttpStatusCode.InternalServerError;
        var message = "An unexpected error occurred.";

        if (exception is ArgumentException)
        {
            statusCode = HttpStatusCode.BadRequest;
            message = exception.Message;
        }

        var response = new ApiResponse
        {
            Success = false,
            Code = (int)statusCode,
            Data = null,
            Message = message
        };

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;

        return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
    }
}