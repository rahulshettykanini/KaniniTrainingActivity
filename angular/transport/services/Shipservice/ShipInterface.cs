using transport.Models;

namespace transport.services.Shipservice
{
    public interface ShipInterface
    {
        public Task<List<Ship>> GetShips();
        public Task<Ship?> GetShip(string id);
        public Task<Ship?> PutShip(string id, Ship ship);

        public Task<List<Ship>> PostShip(Ship ship);

        public Task<List<Ship?>> DeleteShip(string id);

        

    }
}
