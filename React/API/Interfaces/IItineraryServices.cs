using MakeYourTrip.Models;

namespace MakeYourTrip.Repository.Interfaces
{
    public interface IItineraryServices
    {


        public Task<List<ItineraryDetail>> GetItineraryDetails();
        public Task<ItineraryDetail?> GetItineraryDetail(int id);
        public Task<ItineraryDetail?> PutItineraryDetail(int id, ItineraryDetail itineraryDetail);

        public Task<List<ItineraryDetail>> PostItineraryDetail(ItineraryDetail itineraryDetail);

        public Task<List<ItineraryDetail?>> DeleteItineraryDetail(int id);

    }
}
