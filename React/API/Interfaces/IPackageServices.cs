using MakeYourTrip.Models;

namespace MakeYourTrip.Repository.Interfaces
{
    public interface IPackageServices
    {

        public Task<List<Package>> GetPackages();
        public Task<Package?> GetPackage(int id);
        public Task<Package?> PutPackage(int id, Package package);

        public Task<List<Package>> PostPackage(Package package);

        public Task<List<Package?>> DeletePackage(int id);


    }
}
