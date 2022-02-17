using BackEnd.Data.Models;
using BackEnd.Repositories.Abstraction;
using BackEnd.Services.Abstraction;

namespace BackEnd.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<User> LoginUserAsync(User user)
        {
             return await userRepository.GetUserByIdAsync(user.Id);
        }
    }
}
