using MakeYourTrip.Models;

namespace MakeYourTrip.Repository.Interfaces
{
    public interface IBookingServices
    {


        public Task<List<BookingTrip>> GetBookingTrips();
        public Task<BookingTrip?> GetBookingTrip(int id);
        public Task<BookingTrip> PutBookingTrip(int id, BookingTrip bookingTrip);

        public Task<List<BookingTrip>> PostBookingTrip(BookingTrip bookingTrip);

        public Task<List<BookingTrip?>> DeleteBookingTrip(int id);

    }
}
