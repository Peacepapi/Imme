using Imme.Models.Entities;

namespace Imme.Models.DTOs
{
    public record ReponseDeckDto
    {
        public int Id { get; set; }
        public string Topic { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Card> Cards { get; set; } = new List<Card>();
        public int? UserId { get; set; }
    }
}
