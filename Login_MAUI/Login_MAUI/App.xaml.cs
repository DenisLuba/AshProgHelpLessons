using Login_MAUI.Models;
using Login_MAUI.ViewModels;

namespace Login_MAUI
{
    public partial class App : Application
    {
        public static UserInfo? UserInfo { get; set; }
        AppShellViewModel ViewModel;

        public App(AppShellViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell(ViewModel));
        }
    }
}