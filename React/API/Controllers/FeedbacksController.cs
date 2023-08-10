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
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedbackServices _iFeedbackServices;

        public FeedbacksController(IFeedbackServices iFeedbackServices)
        {
            _iFeedbackServices = iFeedbackServices;
        }

        // GET: api/Feedbacks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetFeedbacks()
        {

            return await _iFeedbackServices.GetFeedbacks();
        }

        // GET: api/Feedbacks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Feedback>> GetFeedback(int id)
        {
            var client = await _iFeedbackServices.GetFeedback(id);

            if (client == null)
            {
                return NotFound(" client not found");
            }
            return Ok(client);
        }

        // PUT: api/Feedbacks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeedback(int id, Feedback feedback)
        {
            var clients = await _iFeedbackServices.PutFeedback(id, feedback);
            return Ok(clients);

        }

        // POST: api/Feedbacks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Feedback>> PostFeedback(Feedback feedback)
        {

            var clients = await _iFeedbackServices.PostFeedback(feedback);
            return Ok(clients);
        }

        // DELETE: api/Feedbacks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeedback(int id)
        {
            var clients = await _iFeedbackServices.DeleteFeedback(id);
            return Ok(clients);
        }

       
    }
}
