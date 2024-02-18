using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeMVC.Models
{
    public class Book
    {

        [Key]
        public int BookID { get; set; }

        [Required]
        [RegularExpression(@"\d{10}")]
        public int ISBN { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(30)]
        public string Author { get; set; }
        [Required]
        [RegularExpression(@"\d{4}")]
        [Range(1000, 2024)]
        [DisplayName("Publication Year")]
        public int PublicationYear { get; set; }
        [Required]
        [StringLength(50)]
        public string Genre { get; set; }
    }
}
