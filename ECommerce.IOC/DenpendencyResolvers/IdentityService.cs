using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using ECommerce.Models.Entities;
using ECommerce.DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ECommerce.IOC.DenpendencyResolvers
{
    public static class IdentityService
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppUserRole>()
                .AddEntityFrameworkStores<ECommerceContext>()
                .AddDefaultTokenProviders();//Token oluşturma methodu


            services.Configure<IdentityOptions>(x =>
            {
                x.Password.RequireDigit = true; //en az 1 rakam zorunluluğu
                x.Password.RequireNonAlphanumeric = true; //en az 1 sayı ve numara hariç karakter zorunluluğu
                x.Password.RequireUppercase = true; //en az 1 büyük harf zorunluluğu
                x.Password.RequireLowercase = true; //en az 1 küçük harf zorunluluğu
                x.Password.RequiredLength = 8; //Minimum şifre uzunluğu
            });

            //Cookie Configuration
            services.ConfigureApplicationCookie(cookie =>
            {
                cookie.LoginPath = new PathString("/Home/Login");
                //cookie.AccessDeniedPath = new PathString("/Home/Denied");
                cookie.Cookie = new CookieBuilder { Name = "ECommerceUserCookie" };
                cookie.SlidingExpiration = true;
                cookie.ExpireTimeSpan = TimeSpan.FromMinutes(1);
            });

            return services;
        }


    }
}
