using BestelMy.Models;
using BestelMy.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BestelMy.ViewModels
{
    public class WeatherViewModel : BaseViewmodel
    {
        public Command RefreshCommand { get; set; }

        private IList<OneCallAPI> _weatherList;
        public IList<OneCallAPI> WeatherList

        {
            get
            {
                if (_weatherList == null)
                    _weatherList = new ObservableCollection<OneCallAPI>();
                return _weatherList;
            }
            set
            {
                _weatherList = value;
            }
        }

        private async Task APIAsync()
        {
            var weather = await WeatherAPI.GetOneCallAPIAsync(50.91061, 4.44174, "metric");

            WeatherList.Add(weather);

        }

        public WeatherViewModel()
        {
            Task.Run(APIAsync);
            PageTitle = "Het weer vandaag";

            RefreshCommand = new Command(Refresh);
            IsBusy = false;

        }

        void Refresh()
        {
            WeatherList.Clear();
            IsBusy = true;
                Task.Run(APIAsync);
            IsBusy = false;
        }

    }
}
