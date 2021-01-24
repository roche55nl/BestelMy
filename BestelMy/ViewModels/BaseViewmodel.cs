using BestelMy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace BestelMy.ViewModels
{
    public class BaseViewmodel : INotifyPropertyChanged
    {
        public IDataStore DataStore => DependencyService.Get<IDataStore>();


        public String PageTitle { get; set; }

        double _ItemsTotaal;
        public double ItemsTotaal { get { return _ItemsTotaal; } set { _ItemsTotaal = value; OnPropertyChanged(); } }


        int selectedQuantity;
        public int SelectedQuantity
        {
            get
            {
                return selectedQuantity;
            }
            set
            {
                if (selectedQuantity != value)
                {
                    selectedQuantity = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedQuantity"));
                }
            }
        }

        Boolean _isBusy;
        public Boolean IsBusy { get { return _isBusy; } set { _isBusy = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
