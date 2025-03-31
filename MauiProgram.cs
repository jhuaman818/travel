using Microsoft.Extensions.Logging;
using travel.Views;

namespace travel;
using travel.Services;

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
                fonts.AddFont("FontAwesome.ttf", "FontAwesome");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
            });
        builder.Services.AddSingleton<Inicio>();
        builder.Services.AddSingleton<ApiService>();
        builder.Services.AddSingleton<ViewModels.LoginViewModel>();



#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
