using BackEnd.Data.Models;
using BackEnd.Repositories.Abstraction;
using BackEnd.Services.Abstraction;
using BackEnd.Services.Mappers;
using BackEnd.Services.Requests;

namespace BackEnd.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<ICollection<User>> GetUsersAsync()
        {
            return await this.userRepository.GetAllUsersAsync();
        }

        public async Task<User> LoginUserAsync(User user)
        {
            return await userRepository.GetUserByIdAsync(user.Id);
        }

        public async Task<User> RegisterUserAsync(RegisterUserRequest request)
        {
            var responce = await userRepository.GetUserByEmailAsync(request.Email);
            if (responce == null)
            {
                var user = Mapper.RegisterUserMapper(request);
                return await userRepository.InsertUserAsync(user);
            }
            return null;
        }
        
    }
}
