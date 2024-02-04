using BancoStandard.Front.Models;
using BancoStandard.Front.Services.IServices;
using BancoStandard.Front.Utils;

namespace BancoStandard.Front.Services
{
    public class ContractService : IContractService
    {
        private readonly HttpClient _contract;
        public const string BasePath = "api/v1/contract";

        public ContractService(HttpClient contract)
        {
            _contract = contract ?? throw new ArgumentNullException(nameof(contract));
        }


        public async Task<IEnumerable<ContractModel>> FindAllContracts()
        {
            var response = await _contract.GetAsync(BasePath);
            return await response.ReadContentAs<List<ContractModel>>();
        }

        public async Task<ContractModel> FindContractById(long id)
        {
            var response = await _contract.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ContractModel>();
        }

        public async Task<ContractModel> CreateContract(ContractModel model)
        {
            var response = await _contract.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ContractModel>();
            else throw new Exception("Algo de errado aconteceu!");
        }

        public async Task<ContractModel> UpdateContract(ContractModel model)
        {
            var response = await _contract.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ContractModel>();
            else throw new Exception("Algo de errado aconteceu!");
        }

        public async Task<bool> DeleteContractById(long id)
        {
            var response = await _contract.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else throw new Exception("Algo de errado aconteceu!");
        }
    }
}
