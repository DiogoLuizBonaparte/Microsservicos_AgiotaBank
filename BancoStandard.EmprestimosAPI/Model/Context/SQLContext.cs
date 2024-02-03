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
                Porcentagem = 30,
                TipoPagamento = "Ramo Diário",
                Observacao = "Pagamento em dia"
            });
            modelBuilder.Entity<Contract>().HasData(new Contract
            {
                Id = 2,
                Cliente = "Costa Lucas",
                ValorEmp = 5000,
                ValorDiv = 6500,
                ValorLucro = 1500,
                Porcentagem = 30,
                TipoPagamento = "Pagamento Mensal",
                Observacao = "Pagamento em dia"
            });
            modelBuilder.Entity<Contract>().HasData(new Contract
            {
                Id = 3,
                Cliente = "James de Paris",
                ValorEmp = 5000,
                ValorDiv = 6500,
                ValorLucro = 1500,
                Porcentagem = 30,
                TipoPagamento = "Pagamento Mensal",
                Observacao = "Pagamento em dia"
            });



        }
    }
}