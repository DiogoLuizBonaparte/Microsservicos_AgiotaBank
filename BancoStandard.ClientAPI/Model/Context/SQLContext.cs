using Microsoft.EntityFrameworkCore;

namespace BancoStandard.ClientAPI.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext() { }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
