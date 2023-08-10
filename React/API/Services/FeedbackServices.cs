using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MakeYourTrip.Repository.Services
{
    public class FeedbackServices : IFeedbackServices
    {
        private readonly TourismContext _context;

        public FeedbackServices(TourismContext context)
        {

            _context = context;
        }

        public async Task<List<Feedback>> GetFeedbacks()
        {
            var clients = await _context.Feedbacks.ToListAsync();
            return clients;

        }

        public async Task<Feedback?> GetFeedback(int id)
        {
            var client = await _context.Feedbacks.FindAsync(id);

            return client;
        }

        public async Task<Feedback?> PutFeedback(int id, Feedback feedback)
        {

            var clients = await _context.Feedbacks.FindAsync(id);

            clients.UserId = feedback.UserId;
            clients.FeedbackMessage = feedback.FeedbackMessage;
            clients.Rating = feedback.Rating;
            await _context.SaveChangesAsync();
            return clients;

        }


        public async Task<List<Feedback>> PostFeedback(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return await _context.Feedbacks.ToListAsync();
        }


        public async Task<List<Feedback>> DeleteFeedback(int id)
        {
            var clients = await _context.Feedbacks.FindAsync(id);
            _context.Feedbacks.Remove(clients);
            await _context.SaveChangesAsync();
            return await _context.Feedbacks.ToListAsync();
        }
    }
}
