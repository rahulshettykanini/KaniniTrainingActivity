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
    public class ItineraryDetailsController : ControllerBase
    {
        private readonly IItineraryServices _iItineraryServices;

        public ItineraryDetailsController(IItineraryServices iItineraryServices)
        {
             _iItineraryServices = iItineraryServices;
        }

        // GET: api/ItineraryDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItineraryDetail>>> GetItineraryDetails()
        {


            return await _iItineraryServices.GetItineraryDetails();
        }

        // GET: api/ItineraryDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItineraryDetail>> GetItineraryDetail(int id)
        {
            var client = await _iItineraryServices.GetItineraryDetail(id);

            if (client == null)
            {
                return NotFound(" client not found");
            }
            return Ok(client);
        }

        // PUT: api/ItineraryDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItineraryDetail(int id, ItineraryDetail itineraryDetail)
        {
            var clients = await _iItineraryServices.PutItineraryDetail(id, itineraryDetail);
            return Ok(clients);

        }

        // POST: api/ItineraryDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItineraryDetail>> PostItineraryDetail(ItineraryDetail itineraryDetail)
        {

            var clients = await _iItineraryServices.PostItineraryDetail(itineraryDetail);
            return Ok(clients);

        }

        // DELETE: api/ItineraryDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItineraryDetail(int id)
        {
            var clients = await _iItineraryServices.DeleteItineraryDetail(id);
            return Ok(clients);
        }

       
    }
}
