using testApi.Models;

namespace testApi.Services
{
    public class RoleService
    {
        private readonly ApplicationDbContext _context;

        public RoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Role> AddRole(Guid userId, string roleName)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                throw new Exception("Utilisateur non trouvé");
            }

            var role = new Role
            {
                RoleName = roleName,
                User = user
            };

            _context.Roles.Add(role);
            await _context.SaveChangesAsync();

            return role;
        }
    }

}
