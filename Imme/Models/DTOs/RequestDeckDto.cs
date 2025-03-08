namespace Imme.Models.DTOs
{
    public record RequestDeckDto
    {
        public string Topic { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
