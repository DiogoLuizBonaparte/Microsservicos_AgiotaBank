using BancoStandard.CadastroAPI.Data.ValueObjects;

namespace BancoStandard.CadastroAPI.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<ClienteVO>> FindAll();
        Task<ClienteVO> FindById(long id);
        Task<ClienteVO> Create(ClienteVO vo);
        Task<ClienteVO> Update(ClienteVO vo);
        Task<bool> Delete(long id);
    }
}
