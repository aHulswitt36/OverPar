using OverPar.ViewModels;

namespace OverPar.Pages;

public partial class Scorecard : ContentPage
{
	public Scorecard(ScorecardViewModel vm)
	{		 
		InitializeComponent();
		BindingContext = vm;
	}
}