using BackEnd.Data.Models;

namespace BackEnd.Repositories.Abstraction
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByEmailAsync(string email);
        Task<User> GetUserByPasswordAsync(string password);
        Task<User> GetUserByEmailAndPasswordAsync(string Email, string Password);
        Task<User> InsertUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
        
    }
}
