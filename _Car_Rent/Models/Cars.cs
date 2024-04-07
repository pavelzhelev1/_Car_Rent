using System.ComponentModel.DataAnnotations;

namespace Car_Rent.Models
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int MakeYear { get; set; }
        [Required]
        public bool IsTaken { get; set; }
        [Required]
        public int PassengerCount { get; set; }
        [Required]
        public double PriceForADay { get; set; }

    }
}
