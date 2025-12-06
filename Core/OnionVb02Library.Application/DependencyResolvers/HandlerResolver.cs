using Microsoft.Extensions.DependencyInjection;
using OnionVb02Library.Application.Mediatrs.Handlers.Modify.BookCommandHandlers;
using OnionVb02Library.Application.Mediatrs.Handlers.Modify.BookTagCommandHandlers;
using OnionVb02Library.Application.Mediatrs.Handlers.Modify.CategoryCommandHandlers;
using OnionVb02Library.Application.Mediatrs.Handlers.Modify.TagCommandHandlers;
using OnionVb02Library.Application.Mediatrs.Handlers.Read.BookQueryHandlers;
using OnionVb02Library.Application.Mediatrs.Handlers.Read.BookTagQueryHandlers;
using OnionVb02Library.Application.Mediatrs.Handlers.Read.CategoryQueryHandlers;
using OnionVb02Library.Application.Mediatrs.Handlers.Read.TagQueryHandlers;
using OnionVb02Library.Application.MappingProfiles;

namespace OnionVb02Library.Application.DependencyResolvers
{
    public static class HandlerResolver
    {
        public static void AddHandlerService(this IServiceCollection services)
        {
            // CATEGORY
            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();

            // BOOK
            services.AddScoped<GetBookQueryHandler>();
            services.AddScoped<GetBookByIdQueryHandler>();
            services.AddScoped<CreateBookCommandHandler>();
            services.AddScoped<UpdateBookCommandHandler>();
            services.AddScoped<RemoveBookCommandHandler>();

            // TAG
            services.AddScoped<GetTagQueryHandler>();
            services.AddScoped<GetTagByIdQueryHandler>();
            services.AddScoped<CreateTagCommandHandler>();
            services.AddScoped<UpdateTagCommandHandler>();
            services.AddScoped<RemoveTagCommandHandler>();

            // BOOKTAG
            services.AddScoped<GetBookTagQueryHandler>();
            services.AddScoped<CreateBookTagCommandHandler>();
            services.AddScoped<RemoveBookTagCommandHandler>();

            // MEDIATR
            services.AddMediatR(x =>
                x.RegisterServicesFromAssembly(typeof(GetCategoryByIdQueryHandler).Assembly));

            // AUTOMAPPER PROFILES
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<CommandMappingProfile>();
                cfg.AddProfile<QueryResultMappingProfile>();
            });
        }
    }
}
