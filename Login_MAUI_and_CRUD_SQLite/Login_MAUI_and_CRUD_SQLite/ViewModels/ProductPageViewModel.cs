using CommunityToolkit.Mvvm.Input;
using Login_MAUI.Pages;

namespace Login_MAUI.ViewModels;

public partial class ProductPageViewModel : BaseProductViewModel
{
    #region OnAddProduct Method
    [RelayCommand]
    async Task AddProduct()
        => await Shell.Current.GoToAsync(nameof(AddProductPage)); 
    #endregion
}
