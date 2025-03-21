using CommunityToolkit.Mvvm.Input;
using Login_MAUI.Models;
using Login_MAUI.Services.ProductService;

namespace Login_MAUI.ViewModels;

public partial class AddProductPageViewModel : BaseProductViewModel
{
    #region Private Variables
    IProductRepository productRepository; 
    #endregion

    #region Constructor
    public AddProductPageViewModel(IProductRepository productRepository)
    {
        ProductInfo = new ProductInfo();
        this.productRepository = productRepository;
    }
    #endregion

    #region SaveProduct Method
    [RelayCommand]
    async Task SaveProduct()
    {
        var product = ProductInfo;
        await productRepository.AddUpdateProductAsync(product);

        await Shell.Current.GoToAsync("..");
    } 
    #endregion

    #region Cancel Method
    [RelayCommand]
    async Task Cancel()
    {
        await Shell.Current.GoToAsync("..");
    } 
    #endregion
}
