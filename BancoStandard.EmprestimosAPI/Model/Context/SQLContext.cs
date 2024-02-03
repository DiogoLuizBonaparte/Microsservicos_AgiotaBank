using Microsoft.EntityFrameworkCore;

namespace BancoStandard.EmprestimosAPI.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext() { }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }
        public DbSet<Contract> Contracts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>().HasData(new Contract
            {
                Id = 1,
                Cliente = "Napoleão Bonaparte",
                ValorEmp = 1000,
                ValorDiv = 1300,
                ValorLucro = 300,
                TipoPagamento = "Ramo Diário",
                DataEmp = 03 / 02 / 2024,
                DataAcordo = 03 / 03 / 2024,
                DataFinal = 03 / 03 / 2024,
                Observacao = "Pagamento em dia"
            });
            modelBuilder.Entity<Contract>().HasData(new Contract
            {
                Id = 2,
                Cliente = "Costa Lucas",
                ValorEmp = 5000,
                ValorDiv = 6500,
                ValorLucro = 1500,
                TipoPagamento = "Pagamento Mensal",
                DataEmp = 05 / 02 / 2024,
                DataAcordo = 05 / 03 / 2024,
                DataFinal = 05 / 03 / 2024,
                Observacao = "Pagamento em dia"
            });

        }
    }
}
