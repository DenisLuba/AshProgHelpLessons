using CommunityToolkit.Mvvm.ComponentModel;
using Login_MAUI.Models;

namespace Login_MAUI.ViewModels;

public partial class BaseProductViewModel : BaseViewModel
{
    [ObservableProperty]
    ProductInfo _productInfo;
}
