using System.ComponentModel.DataAnnotations;

namespace BancoStandard.Front.Models
{
    public class ContractModel
    {
        public long Id { get; set; }
        [Required]
        public string Cliente { get; set; }

        [Required]
        public double ValorEmp { get; set; }

        [Required]
        public double ValorDiv { get; set; }

        [Required]
        public double ValorLucro { get; set; }

        [Required]
        public double Porcentagem { get; set; }
        
        [Required]
        public string TipoPagamento { get; set; }

        [Required]
        public DateTime DataEmp { get; set; }

        [Required]
        public DateTime DataAcordo { get; set; }

        
        public DateTime DataFinal { get; set; }

        public string Observacao { get; set; }
    }
}

