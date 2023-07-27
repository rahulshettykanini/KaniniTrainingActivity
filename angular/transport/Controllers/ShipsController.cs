using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using transport.Models;
using transport.services.Shipservice;

namespace transport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipsController : ControllerBase
    {
        private readonly ShipInterface _shipinterface;

        public ShipsController(ShipInterface shipinterface)
        {
            _shipinterface = shipinterface;
        }

        // GET: api/Ships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShips()
        {
         

            return await _shipinterface.GetShips();
        }

        // GET: api/Ships/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ship>> GetShip(string id)
        {
            var client = await _shipinterface.GetShip(id);

            if (client == null)
            {
                return NotFound(" client not found");
            }
            return Ok(client);
        }

        // PUT: api/Ships/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShip(string id, Ship ship)
        {
            var clients = await _shipinterface.PutShip(id, ship);
            return Ok(clients);
        }

        // POST: api/Ships
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ship>> PostShip(Ship ship)
        {
            var clients = await _shipinterface.PostShip(ship);
            return Ok(clients);
        }

        // DELETE: api/Ships/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShip(string id)
        {

            var clients = await _shipinterface.DeleteShip(id);
            return Ok(clients);
        }

       
    }
}
