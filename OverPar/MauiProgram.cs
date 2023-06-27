using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OverPar.Pages;
using OverPar.ViewModels;
using System.Reflection;
using OverPar.Domain.Settings;

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
		//var a = Assembly.GetExecutingAssembly();
		//using var stream = a.GetManifestResourceStream("OverPar.appsettings.json");
		//var config = new ConfigurationBuilder()
		//	.AddJsonStream(stream)
		//	.Build();

		//builder.Configuration.AddConfiguration(config);
		//builder.Configuration.AddJsonFile("OverPar.appsettings.json");
		//builder.Services.AddOptions();
		//var formReaderSettings = builder.Configuration.GetSection("ScorecardReader").Get<FormReaderSettings>();
		//builder.Services.Configure<FormReaderSettings>((IConfiguration)formReaderSettings);

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
