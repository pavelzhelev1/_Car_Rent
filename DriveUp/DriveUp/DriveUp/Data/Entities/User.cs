using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DriveUp.Data.Entities
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string? ProfileName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? LastName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string? EGN { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string isAdmin { get; set; }
    }
}
