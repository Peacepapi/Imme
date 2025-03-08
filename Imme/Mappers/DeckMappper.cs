using Imme.Models.DTOs;
using Imme.Models.Entities;

namespace Imme.Mappers
{
    public static class DeckMappper
    {
        public static ReponseDeckDto ToResponseDeckDto(this Deck deck)
        {
            return new ReponseDeckDto
            {
                Id = deck.Id,
                Topic = deck.Topic,
                Description = deck.Description,
                UserId = deck.UserId,
                Cards = deck.Cards
            };
        }

        public static Deck FromRequestDeckDto(this RequestDeckDto requestDeckDto, int userId)
        {
            return new Deck()
            {
                UserId = userId,
                Description = requestDeckDto.Description,
                Topic = requestDeckDto.Topic
            };
        }
    }
}
