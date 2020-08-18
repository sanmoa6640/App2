using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Composition;
using Windows.UI.Popups;

namespace App2
{
    public class Recording : BaseViewModel
    {
        private string artistName;
        public string ArtistName
        {
            get { return artistName; }
            set 
            {   SetProperty(ref artistName, value);
                OnPropertyChanged2();
            }
        }

        private string compositionName;
        public string CompositionName
        {
            get { return compositionName; }
            set 
            {   SetProperty(ref compositionName, value);
                OnPropertyChanged2();
            }
        }

        private DateTime releaseDateTime;
        public DateTime ReleaseDateTime 
        { 
            get { return releaseDateTime; } 
            set { SetProperty(ref releaseDateTime, value); }
        }

        public Recording()
        {
            this.ArtistName = "Wolfgang Amadeus Mozart";
            this.CompositionName = "Andante in C for Piano";
            this.ReleaseDateTime = new DateTime(1761, 1, 1);
        }
        private String onlineSummary;
        public string OneLineSummary
        {
            get
            {
                return $"{this.CompositionName} by {this.ArtistName}, released: "
                    + this.ReleaseDateTime.ToString("d");
            }
            set
            {
                OnPropertyChanged2();
            }
            
        }

    }
    public class RecordingViewModel : BaseViewModel
    {
        private Recording defaultRecording = new Recording();
        public Recording DefaultRecording { get { return this.defaultRecording; } set { SetProperty(ref this.defaultRecording, value); OnPropertyChanged2(); } }
        public RecordingViewModel()
        {
            
        }
        public async void MakeSomeAsync()
        {
            var message = "Santiago Morales ";

            var messageDialog = new MessageDialog(message, "Person data:");

            await messageDialog.ShowAsync();
        }
    }
}
