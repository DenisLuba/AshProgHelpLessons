using CommunityToolkit.Mvvm.Input;
using Login_MAUI.Pages;

namespace Login_MAUI.ViewModels;

public partial class AppShellViewModel : BaseViewModel
{
    [RelayCommand]
    async Task SignOut()
    {
        if (Preferences.ContainsKey(nameof(App.UserInfo)))
            Preferences.Remove(nameof(App.UserInfo));

        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        Shell.Current.FlyoutIsPresented = false;
    }
}
