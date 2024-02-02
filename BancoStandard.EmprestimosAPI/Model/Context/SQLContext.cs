using Microsoft.EntityFrameworkCore;

namespace BancoStandard.EmprestimosAPI.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext() { }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }
        public DbSet<Contract> Contracts { get; set; }
    }
}
