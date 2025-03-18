using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FitLifeGym.Models;

namespace FitLifeGym.Models
{

    public class Membership
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public bool Status { get; set; } = true;

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
