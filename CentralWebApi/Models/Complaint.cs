using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentralWebApi.Models
{
    public class Complaint : BaseModel
    {

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [Phone]
        public string MobileNumber { get; set; }

        [Required]
        public string ComplaintDetails { get; set; }

        public string IPAddress { get; set; }


        // Additional logic or methods can be added here if necessary
    }
}
