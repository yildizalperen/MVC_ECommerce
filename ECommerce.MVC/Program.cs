using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.Services.Concretes;
using ECommerce.DAL.Context;
using ECommerce.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Cookie Configuration
builder.Services.ConfigureApplicationCookie(cookie =>
{
    cookie.LoginPath = new PathString("/Home/Login");
    cookie.AccessDeniedPath = new PathString("/Home/Denied");
    cookie.Cookie = new CookieBuilder { Name = "ECommerceUserCookie" };
    cookie.SlidingExpiration = true;
    cookie.ExpireTimeSpan = TimeSpan.FromMinutes(1);
});


//DependencyInjections

//AddDbContext
builder.Services.AddDbContext<ECommerceContext>(options => options.UseSqlServer("server=DESKTOP-22DN80G;database=MVC_ECommerce;Trusted_Connection=True;TrustServerCertificate=true", b => b.MigrationsAssembly("ECommerce.MVC")));

//Repository Services
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

//Entity Services

//CategoryService
builder.Services.AddScoped<ICategoryService, CategoryService>();
//ProductService
builder.Services.AddScoped<IProductService, ProductService>();
//SupplierService
builder.Services.AddScoped<ISupplierService, SupplierSerivce>();
//OrderService
builder.Services.AddScoped<IOrderService, OrderService>();

//User Manager
builder.Services.AddIdentity<AppUser, AppUserRole>()
    .AddEntityFrameworkStores<ECommerceContext>()
    .AddDefaultTokenProviders();//Token oluşturma methodu

builder.Services.Configure<IdentityOptions>(x =>
{
    x.Password.RequireDigit = true; //en az 1 rakam zorunluluğu
    x.Password.RequireNonAlphanumeric = true; //en az 1 sayı ve numara hariç karakter zorunluluğu
    x.Password.RequireUppercase = true; //en az 1 büyük harf zorunluluğu
    x.Password.RequireLowercase = true; //en az 1 küçük harf zorunluluğu
    x.Password.RequiredLength = 8; //Minimum şifre uzunluğu
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); //Yetkilendirme
app.UseAuthentication(); //Kimlik yönetimi

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
       name: "activationUrl",
    pattern: "{controller=Home}/{action=Activation}/{id}/{token}"
    );

    endpoints.MapControllerRoute(
       name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    
});

app.Run();
