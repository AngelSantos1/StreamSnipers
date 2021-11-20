using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PreviousSearch
    {
        public int PreviousSearchId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public string Search { get; set; }
    }
}