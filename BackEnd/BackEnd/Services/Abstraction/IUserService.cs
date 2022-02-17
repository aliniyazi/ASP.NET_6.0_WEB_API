using BackEnd.Data.Models;

namespace BackEnd.Services.Abstraction
{
    public interface IUserService
    {
        Task<User> LoginUserAsync(User user);
        Task<User> RegisterUserAsync(User user);
    }
}
