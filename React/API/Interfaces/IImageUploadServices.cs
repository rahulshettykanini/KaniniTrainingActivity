using MakeYourTrip.Models;

namespace MakeYourTrip.Repository.Interfaces
{
    public interface IImageUploadServices
    {


        public Task<List<AdminImageUpload>> GetAdminImageUploads();
        public Task<AdminImageUpload?> GetAdminImageUpload(int id);
        public Task<AdminImageUpload?> PutAdminImageUpload(int id, AdminImageUpload adminImageUpload);

        public Task<List<AdminImageUpload>> PostAdminImageUpload(AdminImageUpload adminImageUpload);

        public Task<List<AdminImageUpload?>> DeleteAdminImageUpload(int id);

    }
}
