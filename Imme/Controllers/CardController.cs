using Imme.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imme.Controllers
{
    [Route("api/card")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardRepository _cardRepo;
        public CardController(ICardRepository cardRepo)
        {
            _cardRepo = cardRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cards = await _cardRepo.GetAllAsync();
            return Ok(cards);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var card = await _cardRepo.GetByIdAsync(id);
            return Ok(card);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var card = await _cardRepo.DeleteAsync(id);
            if (card is null) return NotFound("Card not found.");

            return NoContent();
        }
    }
}
