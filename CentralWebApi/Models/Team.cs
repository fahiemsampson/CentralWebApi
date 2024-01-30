using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CentralWebApi.Models
{
    public class Team : BaseModel
    {
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
