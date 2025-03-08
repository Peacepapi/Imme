using Imme.Data;
using Imme.Interfaces;
using Imme.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imme.Repositories
{
    public class DeckRepository : IDeckRepository
    {
        private readonly ApplicationDbContext _context;
        public DeckRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Deck> CreateAsync(Deck deck)
        {
            await _context.AddAsync(deck);
            await _context.SaveChangesAsync();

            return deck;
        }

        public async Task<Deck?> DeleteAsync(int id)
        {
            var deck = await _context.Deck.FirstOrDefaultAsync(d => d.Id == id);
            if (deck is null) return null;

            _context.Deck.Remove(deck);
            await _context.SaveChangesAsync();

            return deck;
        }

        public async Task<List<Deck>> GetAllAsync()
        {
            var decks = await _context.Deck.Include(d => d.Cards).ToListAsync();
            return decks;
        }

        public async Task<Deck?> GetByIdAsync(int id)
        {
            var deck = await _context.Deck.Include(d => d.Cards).FirstOrDefaultAsync(d => d.Id == id);
            return deck;
        }
    }
}
