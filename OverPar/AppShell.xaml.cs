using OverPar.Pages;

namespace OverPar;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Scorecard), typeof(Scorecard));
	}
}
