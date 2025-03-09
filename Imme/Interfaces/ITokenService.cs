using Imme.Models.Entities;

namespace Imme.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
