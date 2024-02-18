using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        [Required]
        public int UserID { get; set; }
        public string Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
   }
}