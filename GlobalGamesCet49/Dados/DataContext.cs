using GlobalGamesCet49.Dados.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GlobalGamesCet49.Dados
{
    public class DataContext : IdentityDbContext<User>
    {

        public DbSet<Contactos> Contactos { get; set; }

        public DbSet<Inscricoes> Inscricoes { get; set; }

        public DbSet<UserLogin> UserLogin { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
