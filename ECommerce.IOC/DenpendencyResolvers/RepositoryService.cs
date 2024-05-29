using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.IOC.DenpendencyResolvers
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {

            //AddDbContext
            services.AddECommerceDB();

            //Repository Services
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

            //Entity Services

            //CategoryService
            services.AddScoped<ICategoryService, CategoryService>();
            //ProductService
            services.AddScoped<IProductService, ProductService>();
            //SupplierService
            services.AddScoped<ISupplierService, SupplierSerivce>();
            //OrderService
            services.AddScoped<IOrderService, OrderService>();



            return services;
        }
    }
}
