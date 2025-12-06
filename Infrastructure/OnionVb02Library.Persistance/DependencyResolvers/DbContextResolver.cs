using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionVb02Library.Persistence.ContextClasses;


namespace OnionVb02Library.Persistence.DependencyResolvers
{
    public static class DbContextResolver
    {
        public static void AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider(); //Servis saglayıcınız sizin farklı assembly'lerdeki configuration yapılarını tanımlamanız icin ihtiyacınız olan bir tiptir...

            IConfiguration configuration = provider.GetRequiredService<IConfiguration>(); //görüldügü üzere yukarıda build edilmiş olan tipiniz sayesinde elinize bir IConfiguration tipi gecer ve bu sayede siz ConnectionString'e ulasım saglarsınız...

            services.AddDbContext<MyContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies()); //LazyLoading aktifleştirilmesi icin Proxies kütüphanesinden gelen UseLazyLoadingProxies metodu burada gözlemlenir...
        }
    }
}
