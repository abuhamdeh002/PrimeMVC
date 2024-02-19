using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeMVC.Models;

namespace PrimeMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
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
        }
        public DbSet<Book> Books { get; set; }
    }
}