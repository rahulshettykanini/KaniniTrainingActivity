using Microsoft.AspNetCore.Mvc;
using transport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace transport.services.Shipservice
{
    public class Shipservice : ShipInterface
    {


            private readonly ShipsContext _context;

            public Shipservice(ShipsContext context)
            {
                _context = context;
            }
            public async Task<List<Ship>> GetShips()
            {
                var clients = await _context.Ships.ToListAsync();
                return clients;

            }

            public async Task<Ship?> GetShip(string id)
            {
                var client = await _context.Ships.FindAsync(id);

                return client;
            }

            public async Task<Ship?> PutShip(string id, Ship ship)
            {

                var clients = await _context.Ships.FindAsync(id);
               
                clients.Capacity = ship.Capacity;
                clients.Starting = ship.Starting;
                clients.Ending = ship.Ending;
                clients.Price = ship.Price;
            await _context.SaveChangesAsync();
                return clients;

            }

            public async Task<List<Ship>> PostShip(Ship ship)
            {
                _context.Ships.Add(ship);
                await _context.SaveChangesAsync();
                return await _context.Ships.ToListAsync();
            }

            public async Task<List<Ship>> DeleteShip(string id)
            {
                var clients = await _context.Ships.FindAsync(id);
                _context.Ships.Remove(clients);
                await _context.SaveChangesAsync();
                return await _context.Ships.ToListAsync();
            }

       
    }
}
