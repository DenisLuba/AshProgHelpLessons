using Login_MAUI.ViewModels;

namespace Login_MAUI.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		entryUserName.Text = string.Empty;
		entryPassword.Text = string.Empty;
    }
}