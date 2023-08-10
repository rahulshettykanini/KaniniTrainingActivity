using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MakeYourTrip.Repository.Services
{
    public class PackageServices :IPackageServices
    {
        private readonly TourismContext _context;

        public PackageServices(TourismContext context)
        {

            _context = context;
        }

        public async Task<List<Package>> GetPackages()
        {
            var clients = await _context.Packages.ToListAsync();
            return clients;

        }

        public async Task<Package?> GetPackage(int id)
        {
            var client = await _context.Packages.FindAsync(id);

            return client;
        }

        public async Task<Package?> PutPackage(int id, Package package)
        {

            var clients = await _context.Packages.FindAsync(id);

            clients.Place = package.Place;
            clients.Duration = package.Duration;
            clients.PackagePrice = package.PackagePrice;
            clients.Description = package.Description;
            clients.PlaceImage = package.PlaceImage;
            clients.PackageName = package.PackageName;
            await _context.SaveChangesAsync();
            return clients;

        }


        public async Task<List<Package>> PostPackage(Package package)
        {
            _context.Packages.Add(package);
            await _context.SaveChangesAsync();
            return await _context.Packages.ToListAsync();
        }


        public async Task<List<Package>> DeletePackage(int id)
        {
            var clients = await _context.Packages.FindAsync(id);
            _context.Packages.Remove(clients);
            await _context.SaveChangesAsync();
            return await _context.Packages.ToListAsync();
        }
    }
}
