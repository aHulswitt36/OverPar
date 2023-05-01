using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using OverPar.Domain.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OverPar.ViewModels
{
    public class ScorecardViewModel : INotifyPropertyChanged
    {
        private readonly FormReaderSettings _formReaderSettings;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand TakePictureCommand { get; }

        public ScorecardViewModel(IConfiguration config)
        {
            _formReaderSettings = config.GetRequiredSection("ScorecardReader").Get<FormReaderSettings>();
            TakePictureCommand = new Command(async () => await TakePictureAsync());
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set 
            { 
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private async Task TakePictureAsync()
        {
            if (_isBusy)
                return;

            IsBusy = true;

            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                var stream = await photo.OpenReadAsync();


            }catch(Exception e)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
