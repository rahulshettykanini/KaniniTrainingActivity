using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MakeYourTrip.Repository.Services
{
    public class BookingServices : IBookingServices
    {
        private readonly TourismContext _context;

        public BookingServices(TourismContext context)
        {

            _context = context;
        }

        public async Task<List<BookingTrip>> GetBookingTrips()
        {
            var clients = await _context.BookingTrips.ToListAsync();
            return clients;

        }

        public async Task<BookingTrip?> GetBookingTrip(int id)
        {
            var client = await _context.BookingTrips.FindAsync(id);

            return client;
        }

        public async Task<BookingTrip?> PutBookingTrip(int id, BookingTrip bookingTrip)
        {

            var clients = await _context.BookingTrips.FindAsync(id);

            clients.BookingTripid = bookingTrip.BookingTripid;
            clients.UserId = bookingTrip.UserId;
            clients.DateOfTheTrip = bookingTrip.DateOfTheTrip;
            clients.DateofBooking = bookingTrip.DateofBooking;
            clients.NumberOfPeople = bookingTrip.NumberOfPeople;
            clients.TotalAmount = bookingTrip.TotalAmount;
            clients.PackageId = bookingTrip.PackageId;
            clients.Hotelid = bookingTrip.Hotelid;
            await _context.SaveChangesAsync();
            return clients;

        }


        public async Task<List<BookingTrip>> PostBookingTrip(BookingTrip bookingTrip)
        {
            _context.BookingTrips.Add(bookingTrip);
            await _context.SaveChangesAsync();
            return await _context.BookingTrips.ToListAsync();
        }


        public async Task<List<BookingTrip>> DeleteBookingTrip(int id)
        {
            var clients = await _context.BookingTrips.FindAsync(id);
            _context.BookingTrips.Remove(clients);
            await _context.SaveChangesAsync();
            return await _context.BookingTrips.ToListAsync();
        }

    }
}
