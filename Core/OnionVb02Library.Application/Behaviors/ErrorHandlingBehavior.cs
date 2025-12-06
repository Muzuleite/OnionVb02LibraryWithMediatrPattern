using MediatR;
using Microsoft.Extensions.Logging;
using OnionVb02Library.Application.Exceptions;

public class ErrorHandlingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
{
    private readonly ILogger<ErrorHandlingBehavior<TRequest, TResponse>> _logger;

    public ErrorHandlingBehavior(
        ILogger<ErrorHandlingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch (NotFoundException ex)
        {
            _logger.LogWarning(ex, "Not Found Error: {RequestName}", typeof(TRequest).Name);

            throw new CustomApiException(
                statusCode: 404,
                message: ex.Message,
                errorCode: "NOT_FOUND"
            );
        }
        catch (BusinessException ex)
        {
            _logger.LogInformation(ex, "Business Error in {RequestName}", typeof(TRequest).Name);

            throw new CustomApiException(
                statusCode: 400,
                message: ex.Message,
                errorCode: "BUSINESS_ERROR"
            );
        }
        catch (CustomValidationException ex)
        {
            _logger.LogInformation(ex, "Validation Error in {RequestName}", typeof(TRequest).Name);

            throw new CustomApiException(
                statusCode: 422,
                message: "Validation Error",
                errors: ex.Errors.ToList()
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled Error in {RequestName}", typeof(TRequest).Name);

            throw new CustomApiException(
                statusCode: 500,
                message: "Unexpected Error Occurred",
                errorCode: "SERVER_ERROR"
            );
        }
    }
}
