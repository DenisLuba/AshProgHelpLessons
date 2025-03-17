using UsersFromWeb_LoginPage_MAUI.Models;
using UsersFromWeb_LoginPage_MAUI.Services;

namespace UsersFromWeb_LoginPage_MAUI.Pages;

public partial class LoginPage : ContentPage
{
	readonly ILoginRepository _loginRepository = new LoginService();

	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Login_Clicked(object sender, EventArgs e)
    {
		string userName = entryUserName.Text;
		string password = entryPassword.Text;

		if (userName is null || password is null)
		{
			await DisplayAlert("Warning", "Please Input Username & Password", "Ok");
			return;
		}
		UserInfo? user = await _loginRepository.Login(userName, password);
		if (user is not null)
		{
			await Navigation.PushAsync(new HomePage());
		}
		else
		{
			await DisplayAlert("Warning", "Username or Password is incorrect.", "Ok");
		}
    }
}