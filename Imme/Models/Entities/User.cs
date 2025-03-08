using Microsoft.AspNetCore.Identity;

namespace Imme.Models.Entities
{
    public class User : IdentityUser
    {
        public List<Deck> Decks { get; set; } = new List<Deck>();
    }
}
