using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit;
using Xunit.Sdk;

namespace RestaurantManager.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [FutureDate(ErrorMessage = "Reservation time must be in the future.")]
        public DateTime ReservationTime { get; set; }

        [Required]
        [Range(1, 100)]
        public int NumberOfGuests { get; set; }
        public string? SpecialRequests { get; set; }
    }
}
