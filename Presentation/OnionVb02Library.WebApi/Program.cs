using MediatR;
using OnionVb02Library.Application.DependencyResolvers;
using OnionVb02Library.Application.MappingProfiles;
using OnionVb02Library.Persistence.DependencyResolvers;

namespace OnionVb02Library.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddHandlerService();
            builder.Services.AddDbContextService();
            builder.Services.AddRepositoryService();
            builder.Services.AddAutoMapper(typeof(CommandMappingProfile).Assembly);
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ErrorHandlingBehavior<,>));

            builder.Services.AddValidatorServices();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseMiddleware<ApiExceptionMiddleware>();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
