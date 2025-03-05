using Imme.Models.Entities;

namespace Imme.Interfaces
{
    public interface ICardInterface
    {
        Task<List<Card>> GetAllAsync();
        Task<Card?> GetByIdAsync(int id);
        Task<Card> CreateAsync(Card card);
        Task<Card> DeleteAsync(int id);
    }
}
