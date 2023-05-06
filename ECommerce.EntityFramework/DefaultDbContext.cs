using ECommerce.Data.Models;
using ECommerce.Data.Models.Others;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;

namespace ECommerce.EntityFramework
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<LoginInfo>? LoginInfos { get; set; }
        public DbSet<Car>? Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            List<User>? users = new List<User>();
            List<LoginInfo>? loginInfos = new List<LoginInfo>();
            List<Car> cars = new List<Car>();

            Guid? adminUserId = Guid.Parse("777eab55-31b1-494a-b804-078b8eaaa000"); 
            users.Add(new User()
            {
                Id = adminUserId,
                EmailAddress = "admecom@mailinator.com",
                FirstName = "Jace",
                LastName = "Beleren",
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            loginInfos.Add(new LoginInfo()
            {
                Id = Guid.NewGuid(),
                Key = "Password",
                Value = BCrypt.Net.BCrypt.HashPassword("Accord605"),
                UserId = adminUserId,
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            loginInfos.Add(new LoginInfo()
            {
                Id = Guid.NewGuid(),
                Key = "LoginRetries",
                Value = "0",
                UserId = adminUserId,
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            loginInfos.Add(new LoginInfo()
            {
                Id = Guid.NewGuid(),
                Key = "AccountStatus",
                Value = "Active",
                UserId = adminUserId,
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            Guid? customerUserId = Guid.Parse("777eab55-31b1-494a-b804-078b8eccc000");
            users.Add(new User()
            {
                Id = customerUserId,
                EmailAddress = "custecom@mailinator.com",
                FirstName = "Liliana",
                LastName = "Vess",
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            loginInfos.Add(new LoginInfo()
            {
                Id = Guid.NewGuid(),
                Key = "Password",
                Value = BCrypt.Net.BCrypt.HashPassword("Accord605"),
                UserId = customerUserId,
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            loginInfos.Add(new LoginInfo()
            {
                Id = Guid.NewGuid(),
                Key = "LoginRetries",
                Value = "0",
                UserId = customerUserId,
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            loginInfos.Add(new LoginInfo()
            {
                Id = Guid.NewGuid(),
                Key = "AccountStatus",
                Value = "Active",
                UserId = customerUserId,
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });


            cars.Add(new Car()
            {
                Id = Guid.NewGuid(),
                Make = "Xpander Cross",
                Manufacturer = "Mitsubishi",
                Year = 2023,
                CreatedByUserId = adminUserId,
                UpdatedUserId = adminUserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<LoginInfo>().HasData(loginInfos);
            modelBuilder.Entity<Car>().HasData(cars);

            base.OnModelCreating(modelBuilder);
        }
    }
}