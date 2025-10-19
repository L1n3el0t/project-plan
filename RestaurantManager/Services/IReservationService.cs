namespace RestaurantManager.Services
{
    public interface IReservationService
    {
        void CreateReservation(string customerName, DateTime reservationTime, int numberOfGuests);
       
    }
}
