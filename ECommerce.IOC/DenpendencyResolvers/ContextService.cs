using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.IOC.DenpendencyResolvers
{
    public static class ContextService
    {
        public static IServiceCollection AddECommerceDB(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();

            var configuration = provider.GetService<IConfiguration>();

            services.AddDbContext<ECommerceContext>(options => options.UseSqlServer(configuration.GetConnectionString("ClassConnection"), b => b.MigrationsAssembly("ECommerce.MVC")));



            return services;
        }
    }
}
