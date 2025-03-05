using Imme.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imme.Controllers
{
    [Route("api/deck")]
    [ApiController]
    public class DeckController : ControllerBase
    {
        private readonly IDeckRepository _deckRepo;

        public DeckController(IDeckRepository deckRepo)
        {
            _deckRepo = deckRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var decks = await _deckRepo.GetAllAsync();
            return Ok(decks);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var deck = await _deckRepo.GetByIdAsync(id);
            return Ok(deck);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deck = await _deckRepo.DeleteAsync(id);
            if (deck is null) return NotFound("Deck not found.");

            return NoContent();
        }
    }
}
