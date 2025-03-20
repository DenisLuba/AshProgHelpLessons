namespace Login_MAUI.UserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();

		if (App.UserInfo is not null)
		{
			labelUserName.Text = $"Logged in as: {App.UserInfo.username}";
			labelUserEmail.Text = $"{App.UserInfo.username}"; // Set Email from API
		}
	}
}