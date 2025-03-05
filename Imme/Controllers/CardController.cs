using Imme.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Imme.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly CardRepository _cardRepo;
        public CardController(CardRepository cardRepo)
        {
            _cardRepo = cardRepo;
        }

        public async Task<IActionResult> GetAll()
        {
            var cards = await _cardRepo.GetAllAsync();
            return Ok(cards);
        }
    }
}
