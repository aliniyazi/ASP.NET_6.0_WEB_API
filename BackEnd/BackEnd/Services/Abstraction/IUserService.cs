using BackEnd.Data.Models;
using BackEnd.Services.Requests;

namespace BackEnd.Services.Abstraction
{
    public interface IUserService
    {
        Task<string> LoginUserAsync(LoginUserRequest user);
        Task<User> RegisterUserAsync(RegisterUserRequest user);
        Task<ICollection<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
    }
}
