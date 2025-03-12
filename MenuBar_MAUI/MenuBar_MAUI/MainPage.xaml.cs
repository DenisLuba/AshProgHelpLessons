namespace MenuBar_MAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void SaveMenuItem_Clicked(object sender, EventArgs e)
    {
        DisplayAlert(title: "Save", message: "You have clicked on Save Menu", cancel: "Ok");
    }
}
