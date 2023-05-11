using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using testApi.Models;

namespace testApi.Services
{
    public interface IUserService
    {
        DbSet<User> Users { get; }
        Task<User> FindByIdAsync(string userId);
        Task<User> FindByNameAsync(string userName);
        Task<bool> CheckPasswordSignInAsync(User user, string password);
    }


    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<User> Users => _context.Set<User>();

        public async Task<User> FindByIdAsync(string userId)
        {
            return await Users.FindAsync(userId);
        }

        public async Task<User> FindByNameAsync(string userName)
        {
            return await Users.SingleOrDefaultAsync(u => u.Username == userName);
        }

        public async Task<bool> CheckPasswordSignInAsync(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

            return result == PasswordVerificationResult.Success;
        }
    }

}
