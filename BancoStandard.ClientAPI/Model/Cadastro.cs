using BancoStandard.ClientAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoStandard.ClientAPI.Model
{
    [Table("cliente")]
    public class Cadastro : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("profissão")]
        [StringLength(50)]
        public string Profissao { get; set; }

        [Column("modalidade_emp")]
        [StringLength(50)]
        public string ModalidadeEmp { get; set;}
    }
}
