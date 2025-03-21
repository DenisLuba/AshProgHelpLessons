using CommunityToolkit.Maui;
using Login_MAUI.Services;
using Login_MAUI.Services.ProductService;
using Login_MAUI.ViewModels;
using Microsoft.Extensions.Logging;

namespace Login_MAUI
{
    public static class MauiProgram
    {
        //static readonly string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProductDB.db3");
        readonly static string _path = Path.Combine(FileSystem.AppDataDirectory, "ProductDB.db3");

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit()
                .AddServices();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        static MauiAppBuilder AddServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<AppShellViewModel>();
            builder.Services.AddSingleton<AddProductPageViewModel>();
            builder.Services.AddSingleton<ProductPageViewModel>();
            builder.Services.AddSingleton<LoginPageViewModel>();

            builder.Services.AddSingleton<ILoginRepository, LoginService>();
            builder.Services.AddSingleton<IProductRepository>(provider => new ProductService(_path));

            builder.Services.AddSingleton<HttpClient>();

            return builder;
        }
    }
}
