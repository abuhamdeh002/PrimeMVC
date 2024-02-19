using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMVC.Models;
namespace PrimeMVC.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }
   
            [Required(ErrorMessage = "Username/Email Is Required.")]
            public string Username { get; set; }

            [Required(ErrorMessage = "Password Is Required.")]
            public string Password { get; set; }
       
    }
}
