using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Login_MAUI.ViewModels;

public partial class LoginPageViewModel : BaseViewModel
{
    #region Properties
    [ObservableProperty]
    private string _userName;

    [ObservableProperty]
    private string _password;
    #endregion

    #region Login Command
    [RelayCommand]
    public async Task Login()
    {

    } 
    #endregion
}
