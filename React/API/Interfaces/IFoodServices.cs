using MakeYourTrip.Models;

namespace MakeYourTrip.Repository.Interfaces
{
    public interface IFoodServices
    {


        public Task<List<Food>> GetFoods();
        public Task<Food?> GetFood(int id);
        public Task<Food?> PutFood(int id, Food food);

        public Task<List<Food>> PostFood(Food food);

        public Task<List<Food?>> DeleteFood(int id);

    }
}
