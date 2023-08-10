using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;


namespace MakeYourTrip.Repository.Services
{
    public class ImageUploadServices : IImageUploadServices
    {
        private readonly TourismContext _context;

        public ImageUploadServices(TourismContext context)
        {

            _context = context;
        }

        public async Task<List<AdminImageUpload>> GetAdminImageUploads()
        {
            var clients = await _context.AdminImageUploads.ToListAsync();
            return clients;

        }

        public async Task<AdminImageUpload?> GetAdminImageUpload(int id)
        {
            var client = await _context.AdminImageUploads.FindAsync(id);

            return client;
        }

        public async Task<AdminImageUpload?> PutAdminImageUpload(int id, AdminImageUpload adminImageUpload)
        {

            var clients = await _context.AdminImageUploads.FindAsync(id);

            clients.ImageId = adminImageUpload.ImageId;
            clients.UserId = adminImageUpload.UserId;
            clients.ImagePath = adminImageUpload.ImagePath;
            clients.ImageDetail = adminImageUpload.ImageDetail;
            await _context.SaveChangesAsync();
            return clients;

        }


        public async Task<List<AdminImageUpload>> PostAdminImageUpload(AdminImageUpload adminImageUpload)
        {
            _context.AdminImageUploads.Add(adminImageUpload);
            await _context.SaveChangesAsync();
            return await _context.AdminImageUploads.ToListAsync();
        }


        public async Task<List<AdminImageUpload>> DeleteAdminImageUpload(int id)
        {
            var clients = await _context.AdminImageUploads.FindAsync(id);
            _context.AdminImageUploads.Remove(clients);
            await _context.SaveChangesAsync();
            return await _context.AdminImageUploads.ToListAsync();
        }
    }
}
