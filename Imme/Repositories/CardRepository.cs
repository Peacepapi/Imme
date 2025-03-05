using Imme.Data;
using Imme.Interfaces;
using Imme.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imme.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly ApplicationDbContext _context;
        public CardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Card> CreateAsync(Card card)
        {
            throw new NotImplementedException();
        }

        public async Task<Card?> DeleteAsync(int id)
        {
            var card = await _context.Card.FirstOrDefaultAsync(c => c.Id == id);
            if (card is null) return null;

            _context.Card.Remove(card);
            await _context.SaveChangesAsync();

            return card;
        }

        public async Task<List<Card>> GetAllAsync()
        {
            var cards = await _context.Card.ToListAsync();
            return cards;
        }

        public async Task<Card?> GetByIdAsync(int id)
        {
            var card = await _context.Card.FirstOrDefaultAsync(d => d.Id == id);
            return card;
        }
    }
}
