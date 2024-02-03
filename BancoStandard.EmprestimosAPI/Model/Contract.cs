using BancoStandard.EmprestimosAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BancoStandard.EmprestimosAPI.Model
{
        [Table("contract")]
    public class Contract : BaseEntity
    {
        [Column("cliente")]
        [Required]
        [StringLength(50)]
        public string Cliente { get; set; }

        [Column("valor_emp")]
        [Required]
        [StringLength(50)]
        public double ValorEmp { get; set; }

        [Column("valor_div")]
        [Required]
        [StringLength(50)]
        public double ValorDiv { get; set; }

        [Column("valor_luc")]
        [Required]
        [StringLength(50)]
        public double ValorLucro { get; set; }

        [Column("porcentagem")]
        [Required]
        [StringLength(50)]
        public double Porcentagem { get; set; }

        [Column("tipo_pagamento")]
        [Required]
        [StringLength(50)]
        public string TipoPagamento { get; set; }

        [Column("data_emp")]
        [Required]
        [StringLength(50)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataEmp { get; set; }

        [Column("data_acor")]
        [Required]
        [StringLength(50)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAcordo { get; set; }

        [Column("data_final")]
        [Required]
        [StringLength(50)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFinal { get; set; }

        [Column("observacao")]
        [Required]
        [StringLength(50)]
        public string Observacao { get; set; }
    }
}
