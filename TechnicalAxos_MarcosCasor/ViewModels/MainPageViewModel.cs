using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Windows.Input;
using TechnicalAxos_MarcosCasor.Models;
using Newtonsoft.Json;

namespace TechnicalAxos_MarcosCasor.ViewModels
{
     public class MainPageViewModel : BindableObject
    {
        private string _bundleId;
        public string BundleId
        {
            get => _bundleId;
            set
            {
                _bundleId = value;
                OnPropertyChanged();
            }
        }

        private ImageSource _imageSource;
        public ImageSource ImageSource
        {
            get => _imageSource;
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Country> _countries;
        public ObservableCollection<Country> Countries
        {
            get => _countries;
            set
            {
                _countries = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectImageCommand { get; }

        public MainPageViewModel()
        {
            BundleId = AppInfo.PackageName;
            ImageSource = "https://random.dog/af70ad75-24af-4518-bf03-fec4a997004c.jpg";
            SelectImageCommand = new Command(OnSelectImage);
            LoadCountries();
        }

        public MainPageViewModel(bool istTest)
        {
            BundleId = "TechnnicalAssesMent_MarcosCasor";
            ImageSource = "https://random.dog/af70ad75-24af-4518-bf03-fec4a997004c.jpg";
            SelectImageCommand = new Command(OnSelectImage);
            LoadCountries();
        }

        private async void OnSelectImage()
        {
            var result = await FilePicker.PickAsync();
            if (result != null)
            {
                ImageSource = ImageSource.FromFile(result.FullPath);
            }
        }

        private async void LoadCountries()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync("https://restcountries.com/v3.1/all");
                var countries = JsonConvert.DeserializeObject<List<Country>>(response!).Take(20);
                Countries = new ObservableCollection<Country>(countries.OrderBy(c => c.Name.Common));
            }
        }
    }


}

