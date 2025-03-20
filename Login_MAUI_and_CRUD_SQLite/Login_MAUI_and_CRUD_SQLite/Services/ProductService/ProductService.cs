using Login_MAUI.Models;
using SQLite;

namespace Login_MAUI.Services.ProductService;

public class ProductService : IProductRepository
{
    public SQLiteAsyncConnection _database;

    public ProductService(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<ProductInfo>().Wait();
    }

    /// <summary>
    /// Add or Update a product row
    /// </summary>
    /// <param name="productInfo">The product to be added or updated</param>
    /// <returns>true if added or inserted</returns>
    public async Task<bool> AddUpdateProductAsync(ProductInfo productInfo)
        => productInfo.ProductId > 0 // если продукт уже есть в базе данных, то
        ? await _database.UpdateAsync(productInfo) > 0 // изменяем его, иначе
        : await _database.InsertAsync(productInfo) > 0; // добавляем его


    public async Task<bool> DeleteProductAsync(int productId)
        => await _database.DeleteAsync(productId) > 0;

    public async Task<ProductInfo> GetProductAsync(int productId)
        => await _database
        .Table<ProductInfo>()
        .Where(product => product.ProductId == productId)
        .FirstOrDefaultAsync();

    public async Task<IEnumerable<ProductInfo>> GetProductsAsync()
        => await _database.Table<ProductInfo>().ToListAsync();
}
