using OverPar.Pages;
using OverPar.ViewModels;

namespace OverPar;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

