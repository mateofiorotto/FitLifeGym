using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLifeGym.Models
{
    public class User
    {
        public int Id { get; set; }

        [Range(0, 20, ErrorMessage = "Value allowed from 0 to 20.")]
        public int PersonId { get; set; }

        [Column(TypeName = "varchar(35)")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "varchar(60)")]
        [Required, EmailAddress]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Password { get; set; }

        [Column(TypeName = "varchar(20)")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Only numbers are allowed.")]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Role { get; set; }
    }
}
