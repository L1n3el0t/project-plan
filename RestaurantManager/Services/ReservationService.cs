using RestaurantManager.Data;
using RestaurantManager.Models;

namespace RestaurantManager.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationService _reservationService;
        private readonly ILogger<ReservationService> _logger;
        private readonly RestaurantManagerContext _context;
      

        public ReservationService( RestaurantManagerContext context , ILogger<ReservationService> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Implementation of reservation-related business logic will go here in the future.
        public void CreateReservation(string customerName, DateTime reservationTime, int numberOfGuests)
        {
            // Logic to create a new reservation
            Console.WriteLine($"Reservation created for {customerName} at {reservationTime} for {numberOfGuests} guests.");
        }
        
    }
}
