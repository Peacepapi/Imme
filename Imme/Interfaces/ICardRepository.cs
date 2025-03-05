using Imme.Models.Entities;

namespace Imme.Interfaces
{
    public interface ICardRepository
    {
        Task<List<Card>> GetAllAsync();
        Task<Card?> GetByIdAsync(int id);
        Task<Card> CreateAsync(Card card);
        Task<Card?> DeleteAsync(int id);
    }
}
