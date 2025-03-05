using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imme.Controllers
{
    [Route("api/deck")]
    [ApiController]
    public class DeckController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }
    }
}
