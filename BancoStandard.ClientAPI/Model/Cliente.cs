using BancoStandard.ClientAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoStandard.ClientAPI.Model
{
    [Table("cliente")]
    public class Cliente : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("profissao")]
        [StringLength(50)]
        public string Profissao { get; set; }

       
    }
}
