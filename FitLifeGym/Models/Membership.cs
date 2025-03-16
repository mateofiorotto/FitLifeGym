using FitLifeGym.Models;

namespace FitLifeGym.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; } // Active / not active (true / false)
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
