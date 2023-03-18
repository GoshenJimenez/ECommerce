using ECommerce.Contracts;
using ECommerce.Contracts.Users;
using ECommerce.Data.Models;
using ECommerce.EntityFramework;
using ECommerce.MySql.Infrastructure;
using ECommerce.Services;
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

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped(typeof(IUserService), typeof(UserService));

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

app.UseAuthorization();


app.MapRazorPages();

app.Run();
