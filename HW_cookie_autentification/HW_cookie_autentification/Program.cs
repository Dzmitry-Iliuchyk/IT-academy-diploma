using FluentValidation;
using FluentValidation.AspNetCore;
using HW_cookie_autentification.DataAccess;
using HW_cookie_autentification.DataAccess.Repositories.Shop;
using HW_cookie_autentification.DataAccess.Repositories.ShopRepositories;
using HW_cookie_autentification.DataAccess.Repositories.UserRepositories;
using HW_cookie_autentification.DataAccess.Repository;
using HW_cookie_autentification.Filters;
using HW_cookie_autentification.Mapper;
using HW_cookie_autentification.Middlewares;
using HW_cookie_autentification.Models.ShopModels;
using HW_cookie_autentification.Validations;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

// Add services to the container.
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(UserMapperProfile)));

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddStackExchangeRedisCache(options => {
    options.Configuration = "localhost:6379";
    options.InstanceName = "DistributedCacheInstance";

});

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<IRepository<Client>, ClientRepository>();
builder.Services.AddScoped<IRepository<Order>, OrderRepository>();
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
builder.Services.AddScoped<IRepository<ProductType>, ProductTypesRepository>();
builder.Services.AddScoped<IRepository<OrderProduct>, OrderProductRepository>();

builder.Services.AddScoped<IValidator<Order>, OrderValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<ClientValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<RegisterDTOValidator>();

builder.Services.AddDbContext<ShopDbContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnectionString")));

builder.Services.AddDbContext<UserDbContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteUserConnection")));

builder.Services.AddAuthentication("Cookies")
    .AddCookie(options => options.LoginPath = new PathString("/User/Login"));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
    builder =>
    {
        builder.WithOrigins("http://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
    });
});

builder.Services.AddControllersWithViews(opt=>opt.Filters.Add(typeof(LoggingActionFilter)));
builder.Services.AddSwaggerGen();
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{




    //app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseMiddleware(typeof(RequestDurationCalculationMiddleware));
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("AllowAngularOrigins");
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Clients}/{action=Index}/{id?}");
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.Run();
