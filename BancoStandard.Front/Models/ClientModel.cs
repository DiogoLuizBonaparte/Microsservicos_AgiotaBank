using System.ComponentModel.DataAnnotations;

namespace BancoStandard.Front.Models
{
    public class ClientModel
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Profissao { get; set; }

    }
}
