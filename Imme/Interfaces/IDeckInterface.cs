using Imme.Models.Entities;

namespace Imme.Interfaces
{
    public interface IDeckInterface
    {
        Task<List<Deck>> GetAllAsync();
        Task<Deck?> GetByIdAsync(int id);
        Task<Deck> CreateAsync(Deck deck);
        Task<Deck> DeleteAsync(int id);
    }
}
