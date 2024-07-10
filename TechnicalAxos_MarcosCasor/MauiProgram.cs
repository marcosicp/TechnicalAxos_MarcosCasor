using Microsoft.Extensions.Logging;
using TechnicalAxos_MarcosCasor.Models;
using TechnicalAxos_MarcosCasor.ViewModels;
using TechnicalAxos_MarcosCasor.Views;

namespace TechnicalAxos_MarcosCasor;

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
			}).RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews()
            .RegisterModels();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	private static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddSingleton<AppShell>();

        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddTransient<MainPageViewModel>();

        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddTransient<MainPage>();

        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterModels(this MauiAppBuilder mauiAppBuilder)
    {
        _ = mauiAppBuilder.Services.AddTransient<Country>();

        return mauiAppBuilder;
    }
}

