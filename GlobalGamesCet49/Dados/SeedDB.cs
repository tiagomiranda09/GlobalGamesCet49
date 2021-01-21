using GlobalGamesCet49.Dados.Entidades;
using GlobalGamesCet49.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Dados
{
    public class SeedDB
    {


        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();

        }




        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("tiago.e.miranda@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    PrimeiroNome = "Tiago",
                    Apelido = "Miranda",
                    Email = "tiago.e.miranda@gmail.com",
                };

                var result = await this.userHelper.AddUserAsync(user, "987654321");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Nao foi possivel criar o utilizador");
                }

            }

            
        }




        private void AddUserLogin(string nome, User user)
        {
            this.context.UserLogin.Add(new UserLogin
            {

                Nome = nome,
                User = user

            });
        }
    }
}

