using GlobalGamesCet49.Dados.Entidades;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);



        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();


        Task<IdentityResult> UpdateUserAsync(User user);


        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
    }

    public class LoginViewModel
    {
        public string Password { get; internal set; }
        public bool RememberMe { get; internal set; }
        public string Username { get; internal set; }
    }
}
