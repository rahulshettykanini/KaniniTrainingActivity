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
    public class AdminImageUploadsController : ControllerBase
    {
        private readonly IImageUploadServices  _iImageUploadServices;

        public AdminImageUploadsController(IImageUploadServices iImageUploadServices)
        {
            _iImageUploadServices = iImageUploadServices;
        }

        // GET: api/AdminImageUploads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminImageUpload>>> GetAdminImageUploads()
        {

            return await _iImageUploadServices.GetAdminImageUploads();
        }

        // GET: api/AdminImageUploads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminImageUpload>> GetAdminImageUpload(int id)
        {
            var client = await _iImageUploadServices.GetAdminImageUpload(id);

            if (client == null)
            {
                return NotFound(" client not found");
            }
            return Ok(client);
        }

        // PUT: api/AdminImageUploads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminImageUpload(int id, AdminImageUpload adminImageUpload)
        {
            var clients = await _iImageUploadServices.PutAdminImageUpload(id, adminImageUpload);
            return Ok(clients);
        }

        // POST: api/AdminImageUploads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AdminImageUpload>> PostAdminImageUpload(AdminImageUpload adminImageUpload)
        {

            var clients = await _iImageUploadServices.PostAdminImageUpload(adminImageUpload);
            return Ok(clients);
        }

        // DELETE: api/AdminImageUploads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminImageUpload(int id)
        {
            var clients = await _iImageUploadServices.DeleteAdminImageUpload(id);
            return Ok(clients);

        }

       
    }
}
