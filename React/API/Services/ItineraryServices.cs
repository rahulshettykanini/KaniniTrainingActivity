using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MakeYourTrip.Repository.Services
{
    public class ItineraryServices : IItineraryServices
    {
        private readonly TourismContext _context;

        public ItineraryServices(TourismContext context)
        {

            _context = context;
        }

        public async Task<List<ItineraryDetail>> GetItineraryDetails()
        {
            var clients = await _context.ItineraryDetails.ToListAsync();
            return clients;

        }

        public async Task<ItineraryDetail?> GetItineraryDetail(int id)
        {
            var client = await _context.ItineraryDetails.FindAsync(id);

            return client;
        }

        public async Task<ItineraryDetail?> PutItineraryDetail(int id, ItineraryDetail itineraryDetail)
        {

            var clients = await _context.ItineraryDetails.FindAsync(id);

            clients.PackageId = itineraryDetail.PackageId;
            clients.DayNumber = itineraryDetail.DayNumber;
            clients.Activities = itineraryDetail.Activities;
            clients.Time = itineraryDetail.Time;
            clients.ItineraryPlace = itineraryDetail.ItineraryPlace;
            clients.ItineraryImage = itineraryDetail.ItineraryImage;
            await _context.SaveChangesAsync();
            return clients;

        }


        public async Task<List<ItineraryDetail>> PostItineraryDetail(ItineraryDetail itineraryDetail)
        {
            _context.ItineraryDetails.Add(itineraryDetail);
            await _context.SaveChangesAsync();
            return await _context.ItineraryDetails.ToListAsync();
        }


        public async Task<List<ItineraryDetail>> DeleteItineraryDetail(int id)
        {
            var clients = await _context.ItineraryDetails.FindAsync(id);
            _context.ItineraryDetails.Remove(clients);
            await _context.SaveChangesAsync();
            return await _context.ItineraryDetails.ToListAsync();
        }
    }
}
