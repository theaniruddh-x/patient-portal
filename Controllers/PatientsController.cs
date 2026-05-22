using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PatientPortal.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        [HttpGet]

        [Authorize]

        public IActionResult GetPatients()
        {
            var patients = new[]
            {
                new { Id = 1, Name = "Rahul", Disease = "Fever" },
                new { Id = 2, Name = "Anjali", Disease = "Diabetes" }
            };

            return Ok(patients);
        }
    }
}