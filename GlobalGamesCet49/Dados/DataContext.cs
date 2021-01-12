using GlobalGamesCet49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GlobalGamesCet49.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Contactos> Contactos { get; set; }

        public DbSet<Inscricoes> Inscricoes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
