using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BancoStandard.CadastroAPI.Data.ValueObjects
{
    public class ClienteVO
    {     
        public long Id { get; set; }

        public string Name { get; set; }
      
        public string Profissao { get; set; }
    
        public string ModalidadeEmp { get; set; }
    }
}
