using Login_MAUI.Pages;
using Login_MAUI.Services;
using Login_MAUI.ViewModels;
using Microsoft.Extensions.Logging;

namespace Login_MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<AppShellViewModel>();
            builder.Services.AddSingleton<ILoginRepository, LoginService>();
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<HttpClient>();

            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<ContactPage>();
            builder.Services.AddSingleton<AboutPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
