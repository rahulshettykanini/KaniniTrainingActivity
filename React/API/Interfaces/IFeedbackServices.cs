using MakeYourTrip.Models;

namespace MakeYourTrip.Repository.Interfaces
{
    public interface IFeedbackServices
    {


        public Task<List<Feedback>> GetFeedbacks();
        public Task<Feedback?> GetFeedback(int id);
        public Task<Feedback?> PutFeedback(int id, Feedback feedback);

        public Task<List<Feedback>> PostFeedback(Feedback feedback);

        public Task<List<Feedback?>> DeleteFeedback(int id);

    }
}
