using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace DriveUp.Data.Entities
{
    public class Car
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string? Model { get; set; }

        //Year does not have [Range] attribute because it does not accept Date.Now.Year
        //Year validation will be done in Controller
        [Required]
        public int Year { get; set; }

        [Required]
        [Range(1, 12)]
        [DisplayName("Passenger Capacity")]
        public int PassengerCapacity { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 5)]
        public string? Description { get; set; }

        [Required]
        [DisplayName("Rent Price")]
        public decimal RentPrice { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Brand")]
        public string? BrandName { get; set; }

        public bool IsRented { get; set; }


        [DisplayName("Rent Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RentDate { get; set; } = DateTime.Now.Date;

        [DisplayName("Return Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; } = DateTime.Now.Date;

        [DisplayName("Renter")]
        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public RentACarUser? User { get; set; }
    }
}
