using Login_MAUI.Models;

namespace Login_MAUI.Services.ProductService;

public interface IProductRepository
{
    Task<bool> AddUpdateProductAsync(ProductInfo productInfo);
    Task<bool> DeleteProductAsync(int productId);
    Task<ProductInfo> GetProductAsync(int productId);
    Task<IEnumerable<ProductInfo>> GetProductsAsync();
}
