using Login_MAUI.ViewModels;

namespace Login_MAUI.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}