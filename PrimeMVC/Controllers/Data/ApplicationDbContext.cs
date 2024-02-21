using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeMVC.Models;
using System.Data;

namespace PrimeMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // AppDbContext.cs
        public class AppDbContext : DbContext
        {
         

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>(entity =>
                {
                    entity.ToTable("Users");
                    // Configure relationships and properties as needed
                });

                modelBuilder.Entity<IdentityRole>(entity =>
                {
                    entity.ToTable("Roles");
                    // Configure relationships and properties as needed
                });
            }
        }

        // User.cs
        public class User : IdentityUser
        {
            public string Username { get; set; }
            // Additional properties as needed
        }


        public ApplicationDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().HasKey(i => i.Id);
            builder.Entity<IdentityUser>().Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Entity<IdentityUser>().Ignore(i => i.UserName);
            builder.Entity<IdentityUser>().Ignore(i => i.NormalizedUserName);
            builder.Entity<IdentityUser>().Ignore(i => i.EmailConfirmed);
            builder.Entity<IdentityUser>().Ignore(i => i.AccessFailedCount);
            builder.Entity<IdentityUser>().Ignore(i => i.LockoutEnabled);
            builder.Entity<IdentityUser>().Ignore(i => i.TwoFactorEnabled);
            builder.Entity<IdentityUser>().Ignore(i => i.ConcurrencyStamp);
            builder.Entity<IdentityUser>().Ignore(i => i.LockoutEnd);
            builder.Entity<IdentityUser>().Ignore(i => i.PhoneNumberConfirmed);
            builder.Entity<IdentityUser>().Ignore(i => i.SecurityStamp);
            builder.Entity<IdentityUser>().Ignore(i => i.PhoneNumber);


            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "admin",
                ConcurrencyStamp = DateTime.Now.ToString()
            });
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
    }
}