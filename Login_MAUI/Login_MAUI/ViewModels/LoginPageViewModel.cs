using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Login_MAUI.Models;
using Login_MAUI.Pages;
using Login_MAUI.Services;
//using Newtonsoft.Json;
using System.Text.Json;

namespace Login_MAUI.ViewModels;

public partial class LoginPageViewModel(ILoginRepository loginRepository) : BaseViewModel
{
    #region Private Values
    readonly ILoginRepository _loginRepository = loginRepository;
    #endregion

    #region Properties
    [ObservableProperty]
    string _userName;

    [ObservableProperty]
    string _password;
    #endregion

    #region Login Command
    [RelayCommand]
    public async Task Login()
    {
        if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
        {
            UserInfo? userInfo = await _loginRepository.Login(UserName, Password);

            if (userInfo is not null)
            {
                if (Preferences.ContainsKey(nameof(App.UserInfo))) Preferences.Remove(nameof(App.UserInfo));

                //string userDetails = JsonConvert.SerializeObject(userInfo); // популярная сторонняя библиотека Newtonsoft.Json;
                string userDetails = JsonSerializer.Serialize(userInfo); // стандарт для новых проектов - выше производительность и поддержка Microsoft
                Preferences.Set(nameof(App.UserInfo), userDetails);
                App.UserInfo = userInfo;

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
            else
            {
                await Shell.Current.DisplayAlert(title: "Login", message: "An incorrect password or username has been entered.", cancel: "OK");
            }
        }
        else
        {
            await Shell.Current.DisplayAlert(title: "Login", message: "The password or username is not specified.", cancel: "OK");
        }
    }
    #endregion
}
