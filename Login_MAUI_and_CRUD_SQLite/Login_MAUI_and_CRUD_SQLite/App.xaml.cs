using Login_MAUI.Models;
using Login_MAUI.Services.ProductService;
using Login_MAUI.ViewModels;
using SQLite;

namespace Login_MAUI
{
    public partial class App : Application
    {
        #region Private Variable
        readonly AppShellViewModel ViewModel;
        static readonly string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProductDB.db3")
        static ProductService? _productService; 
        #endregion

        #region Public Property
        public static ProductService? ProductService
        {
            get => _productService ?? new ProductService(_path);
            set => _productService = value;
        }

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