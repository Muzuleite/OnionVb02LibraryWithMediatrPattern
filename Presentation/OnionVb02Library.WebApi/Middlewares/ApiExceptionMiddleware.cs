using System.Net;
using System.Text.Json;
using OnionVb02Library.Application.Exceptions;

public class ApiExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ApiExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (CustomValidationException ex)
        {
            context.Response.StatusCode = 400;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsJsonAsync(new
            {
                message = ex.Message,
                errors = ex.Errors
            });
        }
        catch (NotFoundException ex)
        {
            context.Response.StatusCode = 404;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsJsonAsync(new
            {
                message = ex.Message
            });
        }
        catch (CustomApiException ex)
        {
            context.Response.StatusCode = ex.StatusCode;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsJsonAsync(new
            {
                message = ex.Message,
                errors = ex.Errors
            });
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsJsonAsync(new
            {
                message = "Unexpected error occurred.",
                detail = ex.Message
            });
        }
    }
}
