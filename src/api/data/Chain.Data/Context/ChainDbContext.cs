using Chain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Chain.Data.Context
{
    public class ChainDbContext:IdentityDbContext<AppUser>
    {
        public ChainDbContext(DbContextOptions<ChainDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }    
        public DbSet<AppUser> AppUsers { get; set; }
    }
}

