using Imme.Interfaces;
using Imme.Mappers;
using Imme.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Imme.Controllers
{
    [Route("api/deck")]
    [ApiController]
    [Authorize]
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
            var decksDto = decks.Select(d => d.ToResponseDeckDto());

            return Ok(decksDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var deck = await _deckRepo.GetByIdAsync(id);
            if (deck is null) return NotFound("Deck not found.");

            return Ok(deck.ToResponseDeckDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deck = await _deckRepo.DeleteAsync(id);
            if (deck is null) return NotFound("Deck not found.");

            return NoContent();
        }

        [HttpPost]
        [Route("{userId}")]
        public async Task<IActionResult> Create(int userId, [FromBody] RequestDeckDto requestDeckDto)
        {
            var deck = requestDeckDto.FromRequestDeckDto(userId);
            var newDeck = await _deckRepo.CreateAsync(deck);

            return Created();
        }
    }
}
