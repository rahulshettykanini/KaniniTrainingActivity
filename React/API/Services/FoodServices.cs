using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace MakeYourTrip.Repository.Services
{
    public class FoodServices : IFoodServices

    { 
         private readonly TourismContext _context;

    public FoodServices(TourismContext context)
    {

        _context = context;
    }

    public async Task<List<Food>> GetFoods()
    {
        var clients = await _context.Foods.ToListAsync();
        return clients;
    }

    public async Task<Food?> GetFood(int id)
        {
        var client = await _context.Foods.FindAsync(id);

        return client;
        }

    public async Task<Food?> PutFood(int id, Food food)
        {

        var clients = await _context.Foods.FindAsync(id);

        clients.PackageId = food.PackageId;
        clients.FoodType = food.FoodType;
        clients.HotelPrice = food.HotelPrice;
        await _context.SaveChangesAsync();
        return clients;

    }


    public async Task<List<Food>> PostFood(Food food)
        {
        _context.Foods.Add(food);
        await _context.SaveChangesAsync();
        return await _context.Foods.ToListAsync();
    }


    public async Task<List<Food>> DeleteFood(int id)
        {
        var clients = await _context.Foods.FindAsync(id);
        _context.Foods.Remove(clients);
        await _context.SaveChangesAsync();
        return await _context.Foods.ToListAsync();
    }
}
}
