using BancoStandard.EmprestimosAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoStandard.EmprestimosAPI.Model
{
    public class Contract : BaseEntity
    {
        [Column("Cliente")]
        [Required]
        [StringLength(50)]
        public string Cliente { get; set; }

        [Column("Valor_Emp")]
        [Required]
        [StringLength(50)]
        public string ValorEmp { get; set; }

        [Column("Valor_Div")]
        [Required]
        [StringLength(50)]
        public string ValorDiv { get; set; }
    }
}
