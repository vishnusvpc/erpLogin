using erpLogin.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace erpLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> LeadRegister([FromBody]LeadRegister register)
        {
            return Ok();   
        }

       
    }
}
