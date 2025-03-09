using System.ComponentModel.DataAnnotations;

namespace Imme.Models.DTOs.Account
{
    public record LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
