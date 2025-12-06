using Microsoft.Extensions.DependencyInjection;
using OnionVb02Library.Contract.RepositoryInterfaces;
using OnionVb02Library.Persistence.RepositoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02Library.Persistence.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IBookTagRepository, BookTagRepository>();

        }
    }
}
