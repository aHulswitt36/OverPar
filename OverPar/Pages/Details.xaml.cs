using OverPar.ViewModels;

namespace OverPar.Pages;

public partial class Details : ContentPage
{
	public Details(DetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}