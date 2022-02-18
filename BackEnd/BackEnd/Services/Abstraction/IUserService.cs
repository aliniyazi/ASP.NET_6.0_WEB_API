using BackEnd.Data.Models;
using BackEnd.Services.Requests;

namespace BackEnd.Services.Abstraction
{
    public interface IUserService
    {
        Task<User> LoginUserAsync(User user);
        Task<User> RegisterUserAsync(RegisterUserRequest user);
    }
}
