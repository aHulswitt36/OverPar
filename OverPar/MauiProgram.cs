using Microsoft.Extensions.Logging;
using OverPar.Pages;
using OverPar.ViewModels;

namespace OverPar;

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

		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddTransient<ScorecardViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<Scorecard>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
