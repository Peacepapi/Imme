using Imme.Data;
using Imme.Interfaces;
using Imme.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imme.Repositories
{
    public class DeckRepository : IDeckInterface
    {
        private readonly ApplicationDbContext _context;
        public DeckRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Deck> CreateAsync(Deck deck)
        {
            throw new NotImplementedException();
        }

        public Task<Deck> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Deck>> GetAllAsync()
        {
            var decks = await _context.Deck.ToListAsync();
            return decks;
        }

        public async Task<Deck?> GetByIdAsync(int id)
        {
            var deck = await _context.Deck.FirstOrDefaultAsync(d => d.Id == id);
            return deck;
        }
    }
}
