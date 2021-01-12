using GlobalGames.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GlobalGamesCet49.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Contactos> Contactos { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
