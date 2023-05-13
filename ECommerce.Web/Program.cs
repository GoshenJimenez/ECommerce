using ECommerce.Contracts;
using ECommerce.Contracts.Cars;
using ECommerce.Contracts.LoginInfos;
using ECommerce.Contracts.Users;
using ECommerce.Data.Models;
using ECommerce.Data.Models.Others;
using ECommerce.EntityFramework;
using ECommerce.MySql.Infrastructure;
using ECommerce.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DefaultDbContext>(dbContextOptions => dbContextOptions
               .UseMySql(builder.Configuration.GetConnectionString("DefaultConnectionString"),
                   ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnectionString")),
                      mySqlOptions =>
                      {
                          mySqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                          mySqlOptions.MigrationsAssembly(typeof(Program).Namespace);
                      })
               .LogTo(Console.WriteLine, LogLevel.Information)
               .EnableSensitiveDataLogging()
               .EnableDetailedErrors()
);

builder.Services.AddScoped(typeof(IRepository<User>), typeof(Repository<User>));
builder.Services.AddScoped(typeof(IRepository<LoginInfo>), typeof(Repository<LoginInfo>));
builder.Services.AddScoped(typeof(IRepository<Car>), typeof(Repository<Car>));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped(typeof(IUserService), typeof(UserService));
builder.Services.AddScoped(typeof(ILoginInfoService), typeof(LoginInfoService));
builder.Services.AddScoped(typeof(ICarService), typeof(CarService));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.LoginPath = "/account/login";
        options.LogoutPath = "/account/logout";
    });

builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

builder.Services.AddAuthorization();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = "ecommerce";
    options.IdleTimeout = TimeSpan.FromMinutes(60 * 24);
});

builder.Services.AddAutoMapper(typeof(Program), typeof(IService));
// Add services to the container.
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseSession();


app.MapRazorPages();

app.Run();
