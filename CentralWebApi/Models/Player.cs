using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentralWebApi.Models
{
    public class Player : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [Range(1, 100)] // Assuming age range 1-100, adjust as needed
        public int Age { get; set; }

        [Required]
        public string IDNumber { get; set; } // Assuming ID Number is a string; adjust type as needed

        [Required]
        public string Address { get; set; }

        // Foreign key for Team
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
