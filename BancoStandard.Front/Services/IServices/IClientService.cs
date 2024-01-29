using BancoStandard.Front.Models;

namespace BancoStandard.Front.Services.IServices
{
    public interface IClientService
    {
        Task<IEnumerable<ClientModel>> FindAllClients();
        Task<ClientModel> FindClientById(long id);        
        Task<ClientModel> CreateClient(ClientModel model);
        Task<ClientModel> UpdateClient(ClientModel model);
        Task<bool> DeleteClientById(long id);
    }
}
