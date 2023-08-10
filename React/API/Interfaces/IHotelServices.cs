using MakeYourTrip.Models;

namespace MakeYourTrip.Repository.Interfaces
{
    public interface IHotelServices
    {


        public Task<List<Hotel>> GetHotels();
        public Task<Hotel?> GetHotel(int id);
        public Task<Hotel?> PutHotel(int id, Hotel hotel);

        public Task<List<Hotel>> PostHotel(Hotel hotel);

        public Task<List<Hotel?>> DeleteHotel(int id);

    }
}
