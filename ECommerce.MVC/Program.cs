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


//DependencyInjections

//AddDbContext
builder.Services.AddDbContext<ECommerceContext>(options => options.UseSqlServer("Server=KDK-101-PC09-YZ;Database=MVC_ECommerce-P;Trusted_Connection=True;TrustServerCertificate=True",b => b.MigrationsAssembly("ECommerce.MVC")));

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
builder.Services.AddIdentity<AppUser, AppUserRole>().AddEntityFrameworkStores<ECommerceContext>();

builder.Services.Configure<IdentityOptions>(x =>
{
    x.Password.RequireDigit = true;
    x.Password.RequiredLength = 12;
    x.Password.RequireNonAlphanumeric = true;
    x.Password.RequireUppercase = true;
    x.Password.RequireLowercase = true;
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
       name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    
});

app.Run();
