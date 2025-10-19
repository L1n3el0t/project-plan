using System.ComponentModel.DataAnnotations;

namespace RestaurantManager.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
