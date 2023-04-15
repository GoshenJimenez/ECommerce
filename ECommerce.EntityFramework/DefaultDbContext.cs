using ECommerce.Data.Models;
using ECommerce.Data.Models.Others;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerce.EntityFramework
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Car>? Cars { get; set; }
    }
}