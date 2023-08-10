using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MakeYourTrip.Repository.Services
{
    public class HotelServices : IHotelServices
    {
        private readonly TourismContext _context;

        public HotelServices(TourismContext context)
        {

            _context = context;
        }

        public async Task<List<Hotel>> GetHotels()
        {
            var clients = await _context.Hotels.ToListAsync();
            return clients;

        }

        public async Task<Hotel?> GetHotel(int id)
        {
            var client = await _context.Hotels.FindAsync(id);

            return client;
        }

        public async Task<Hotel?> PutHotel(int id, Hotel hotel)
        {

            var clients = await _context.Hotels.FindAsync(id);

            clients.PackageId = hotel.PackageId;
            clients.Hotelname = hotel.Hotelname;
            clients.HotelRating = hotel.HotelRating;
            clients.HotelPrice = hotel.HotelPrice;
            clients.HotelsImage = hotel.HotelsImage;
            await _context.SaveChangesAsync();
            return clients;

        }


        public async Task<List<Hotel>> PostHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
            return await _context.Hotels.ToListAsync();
        }


        public async Task<List<Hotel>> DeleteHotel(int id)
        {
            var clients = await _context.Hotels.FindAsync(id);
            _context.Hotels.Remove(clients);
            await _context.SaveChangesAsync();
            return await _context.Hotels.ToListAsync();
        }
    }
}
