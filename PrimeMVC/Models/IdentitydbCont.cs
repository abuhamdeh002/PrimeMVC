using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace PrimeMVC.Models
{
    public class IdentitydbCont : IdentityDbContext
    {
        public IdentitydbCont(DbContextOptions<IdentitydbCont> options)
            : base(options)
        {
        }
    }
}
