using Microsoft.EntityFrameworkCore;

namespace BancoStandard.ClientAPI.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext() { }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 3,
                Name = "Napoleão Bonaparte",
                Profissao = "Imperador"
            });
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 4,
                Name = "Edmond Safra",
                Profissao = "Banqueiro"
            });
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 5,
                Name = "Geroge H. Bush",
                Profissao = "Político"
            });
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 6,
                Name = "John Rockefeller",
                Profissao = "Industrial"
            });
        }

    }
}
