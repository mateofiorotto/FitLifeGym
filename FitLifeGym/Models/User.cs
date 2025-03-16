using System.ComponentModel.DataAnnotations;

namespace FitLifeGym.Models
{
    public class User
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
    }
}
