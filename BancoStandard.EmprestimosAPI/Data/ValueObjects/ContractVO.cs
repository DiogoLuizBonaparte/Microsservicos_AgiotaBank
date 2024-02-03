using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BancoStandard.EmprestimosAPI.Data.ValueObjects
{
    public class ContractVO
    {
        public long Id {get; set;}
     
        public string Cliente { get; set; }
     
        public double ValorEmp { get; set; }

        public double ValorDiv { get; set; }

        public double ValorLucro { get; set; }
           
        public double Porcentagem { get; set; }

        public string TipoPagamento { get; set; }
      
        public DateTime DataEmp { get; set; }
      
        public DateTime DataAcordo { get; set; }
       
        public DateTime DataFinal { get; set; }
     
        public string Observacao { get; set; }
    }
}
