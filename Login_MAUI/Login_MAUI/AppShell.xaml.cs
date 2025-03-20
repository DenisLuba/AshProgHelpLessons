using Login_MAUI.ViewModels;

namespace Login_MAUI;

public partial class AppShell : Shell
{
    public AppShell(AppShellViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
