using BancoStandard.Front.Models;

namespace BancoStandard.Front.Services.IServices
{
    public interface IContractService
    {

        Task<IEnumerable<ContractModel>> FindAllContracts();
        Task<ContractModel> FindContractById(long id);
        Task<ContractModel> CreateContract(ContractModel model);
        Task<ContractModel> UpdateContract(ContractModel model);
        Task<bool> DeleteContractById(long id);
    }
}
