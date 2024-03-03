using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeMVC.Models;
using System.Data;

namespace PrimeMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // AppDbContext.cs
        //public class AppDbContext : DbContext
        //{
         

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<User>(entity =>
        //        {
        //            entity.ToTable("Users");
        //            // Configure relationships and properties as needed
        //        });

             //        modelBuilder.Entity<IdentityRole>(entity =>
        //        {
        //            entity.ToTable("Roles");
        //            // Configure relationships and properties as needed
        //        });
        //    }
        //}

        // User.cs
        public class User : IdentityUser
        {
            public string Username { get; set; }
            // Additional properties as needed
        }


        
       
        public DbSet<Book> Books { get; set; }
    }
}