using GlobalGamesCet49.Dados.Entidades;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Helpers
{
    public class UserHelper : IUserHelper
    {

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public UserHelper(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword)
        {
            return await this.userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }


        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }


        public async Task LogoutAsync()
        {
            await this.signInManager.SignOutAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }

        public async Task<IdentityResult> UpdateUserAsync(User user)
        {
            return await this.userManager.UpdateAsync(user);
        }

        Task<User> IUserHelper.GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }


        public Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            throw new NotImplementedException();
        }

    }
}
