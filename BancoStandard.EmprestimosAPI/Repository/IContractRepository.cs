using BancoStandard.EmprestimosAPI.Data.ValueObjects;

namespace BancoStandard.EmprestimosAPI.Repository
{
    public interface IContractRepository
    {
        Task<IEnumerable<ContractVO>>FindAll();
        Task<ContractVO> FindById(long id);
        Task<ContractVO> Create(ContractVO vo);
        Task<ContractVO> Update(ContractVO vo);
        Task<ContractVO> Delete(long id);
    }
}
