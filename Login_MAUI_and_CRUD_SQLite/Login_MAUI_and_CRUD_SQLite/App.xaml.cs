using Login_MAUI.Models;
using Login_MAUI.Services.ProductService;
using Login_MAUI.ViewModels;

namespace Login_MAUI
{
    public partial class App : Application
    {
        #region Private Variables
        readonly AppShellViewModel ViewModel; // for the AppShell Constructor
        #endregion

        #region Public Properties
        public static UserInfo? UserInfo { get; set; } 
        #endregion

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