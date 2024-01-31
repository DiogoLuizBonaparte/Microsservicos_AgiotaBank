
using BancoStandard.Front.Models;
using BancoStandard.Front.Services.IServices;
using BancoStandard.Front.Utils;
using System.Net.Http.Headers;

namespace BancoStandard.Front.Services
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/client";

        public ClientService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ClientModel>> FindAllClients()
        {
          var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ClientModel>>();
        }

        public async Task<ClientModel> FindClientById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ClientModel>();
        }
        public async Task<ClientModel> CreateClient(ClientModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)           
                return await response.ReadContentAs<ClientModel>();            
            else  throw new Exception("Algo de errado aconteceu!");            
        }
        public async Task<ClientModel> UpdateClient(ClientModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ClientModel>();
            else throw new Exception("Algo de errado aconteceu!");
        }

        public async Task<bool> DeleteClientById(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else throw new Exception("Algo de errado aconteceu!");
        }

      


       
    }
}
