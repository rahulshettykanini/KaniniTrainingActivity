using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MakeYourTrip.Models;
using MakeYourTrip.Repository.Interfaces;
using MakeYourTrip.Repository.Services;

namespace MakeYourTrip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingTripsController : ControllerBase
    {
        private readonly IBookingServices _iBookingServices;

        public BookingTripsController(IBookingServices iBookingServices)
        {
            _iBookingServices = iBookingServices;
        }

        // GET: api/BookingTrips
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingTrip>>> GetBookingTrips()
        {
            return await _iBookingServices.GetBookingTrips();
        }

        // GET: api/BookingTrips/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingTrip>> GetBookingTrip(int id)
        {
            var client = await _iBookingServices.GetBookingTrip(id);

            if (client == null)
            {
                return NotFound(" client not found");
            }
            return Ok(client);
        }

        // PUT: api/BookingTrips/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingTrip(int id, BookingTrip bookingTrip)
        {
            var clients = await _iBookingServices.PutBookingTrip(id, bookingTrip);
            return Ok(clients);
        }

        // POST: api/BookingTrips
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingTrip>> PostBookingTrip(BookingTrip bookingTrip)
        {

            var clients = await _iBookingServices.PostBookingTrip(bookingTrip);
            return Ok(clients);
        }

        // DELETE: api/BookingTrips/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingTrip(int id)
        {
            var clients = await _iBookingServices.DeleteBookingTrip(id);
            return Ok(clients);
        }

      
    }
}
