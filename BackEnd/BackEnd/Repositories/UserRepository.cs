using BackEnd.Data;
using BackEnd.Data.Models;
using BackEnd.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected DBContext dBContext;
        public UserRepository(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task DeleteUserAsync(int id)
        {
            User user = GetUserByIdAsync(id).Result;
            user.isDeleted = true;
            user.DeletedOn = DateTime.UtcNow;
            await this.dBContext.SaveChangesAsync();
        }

        public async Task<ICollection<User>> GetAllUsersAsync()
        {
            return await dBContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var result = await dBContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            return result;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await dBContext.Users.FindAsync(id);
        }

        public async Task<User> InsertUserAsync(User user)
        {
            var element = await dBContext.Users.AddAsync(user);
            await this.dBContext.SaveChangesAsync();
            return element.Entity;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            this.dBContext.Users.Attach(user);
            this.dBContext.Users.Update(user);
            await this.dBContext.SaveChangesAsync();
            return user;
        }
    }
}
