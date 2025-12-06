using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

public static class ValidationResolver
{
    public static IServiceCollection AddValidatorServices(this IServiceCollection services)
    {
        // tercih: Assembly.GetExecutingAssembly() yerine validator sınıfından assembly belirt
        services.AddValidatorsFromAssembly(typeof(CreateCategoryCommandValidator).Assembly);
        return services;
    }
}