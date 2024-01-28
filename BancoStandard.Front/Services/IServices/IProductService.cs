using BancoStandard.Front.Models;

namespace BancoStandard.Front.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProducyModel>> FindAllProducts();
        Task<ProducyModel> FindProductById(long id);        
        Task<ProducyModel> CreateProduc(ProducyModel model);
        Task<ProducyModel> UpdateProduct(ProducyModel model);
        Task<bool> DeleteProductById(long id);
    }
}
