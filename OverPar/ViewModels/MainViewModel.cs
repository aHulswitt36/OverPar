using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OverPar.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPar.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        
        public MainViewModel() { }

        [RelayCommand]
        async Task Navigate() => await Shell.Current.GoToAsync(nameof(Scorecard));
    }
}
