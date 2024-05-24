using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.Services.Abstracts;
using ECommerce.BLL.Services.Concretes;
using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//DependencyInjections

//AddDbContext
builder.Services.AddDbContext<ECommerceContext>(options => options.UseSqlServer("server=DESKTOP-22DN80G;database=MVC_ECommerce;Trusted_Connection=True;TrustServerCertificate=true"));

//Repository Services
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

//Entity Services

//CategoryService
builder.Services.AddScoped<ICategoryService, CategoryService>();

//ProductService
builder.Services.AddScoped<IProductService, ProductService>();

//SupplierService
builder.Services.AddScoped<ISupplierService, SupplierSerivce>();


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

app.UseAuthorization();

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