using Microsoft.AspNetCore.Identity;

namespace GlobalGamesCet49.Dados.Entidades
{
    public class User : IdentityUser
    {
        public string PrimeiroNome { get; set; }

        public string Apelido { get; set; }
    }
}
