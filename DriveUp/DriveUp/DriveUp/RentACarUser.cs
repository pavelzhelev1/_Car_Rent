using DriveUp.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DriveUp
{
    public class RentACarUser : IdentityUser
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        [DisplayName("Username")]
        public string? ProfileName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [Required]
        [RegularExpression(@"^\d+$")]
        [StringLength(10, MinimumLength = 10)]
        [DisplayName("EGN")]
        public string? EGN { get; set; }
        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
