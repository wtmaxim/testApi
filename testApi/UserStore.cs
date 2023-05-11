using Microsoft.AspNetCore.Identity;
using testApi.Models;

namespace testApi
{
    public class UserStore : IUserStore<User>, IUserPasswordStore<User>
    {
        public Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour créer un utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour mettre à jour un utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour supprimer un utilisateur de votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            // Logique pour rechercher un utilisateur par ID dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            // Logique pour rechercher un utilisateur par nom d'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour obtenir l'ID de l'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour obtenir le nom d'utilisateur normalisé de l'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            // Logique pour définir le nom d'utilisateur normalisé de l'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            // Logique pour définir le nom d'utilisateur de l'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour obtenir le nom d'utilisateur de l'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken)
        {
            // Logique pour définir le hachage du mot de passe de l'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour obtenir le hachage du mot de passe de l'utilisateur dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
        {
            // Logique pour vérifier si l'utilisateur a un mot de passe dans votre système de stockage personnalisé
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // Logique pour libérer les ressources, si nécessaire
        }
    }

}
