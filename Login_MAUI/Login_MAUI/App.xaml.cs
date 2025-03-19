using Login_MAUI.Models;

namespace Login_MAUI
{
    public partial class App : Application
    {
        public static UserInfo? UserInfo { get; set; }

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}