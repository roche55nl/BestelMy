using BestelMy.Models;
using BestelMy.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace BestelMy.ViewModels
{
    public class GerechtListViewmodel : BaseViewmodel
    {

        public ObservableCollection<Gerecht> GerechtList { get; set; }
        public Gerecht SelectedGerecht { get; set; }
        public Command DeleteCommand { get; set; }
        public Command GoTo { get; set; }
        public Command AddCommand { get; set; }
        public Command Bereken { get; set; }

        private bool _BerekenIsEnabled;
        public bool BerekenIsEnabled
        {
            get => _BerekenIsEnabled;
            set
            {
                _BerekenIsEnabled = value;
                Bereken.ChangeCanExecute();
                OnPropertyChanged();

            }
        }


        public GerechtListViewmodel()
        {
            PageTitle = "Bestelling";
            Bereken = new Command(BerekenTotaal);
            BerekenIsEnabled = true;

            DeleteCommand = new Command(DeleteGerecht);
            AddCommand = new Command(GoToAddPage);
            GoTo = new Command(NaarHetWeer);
            GerechtList = new ObservableCollection<Gerecht>();
            var itemsTotaal = ItemsTotaal.ToString();
            ItemsTotaal = GerechtList.Sum(g => g.Prijs);

            GetData();

        }
        public void NaarHetWeer()
        {
            App.Current.MainPage.Navigation.PushAsync(new WeatherPage());
        }
        async public void GetData()
        {
            var TodoFromDataStore = DataStore.GetAllGerecht();
            GerechtList.Clear();
            foreach (var gerecht in TodoFromDataStore)
            {

                GerechtList.Add(gerecht);
            }
        }

        public void GoToAddPage()
        {
            BerekenIsEnabled = true;
            if (DataStore.GerechtList.Count == 0)
            {
                ItemsTotaal = 0;
            }
            App.Current.MainPage.Navigation.PushAsync(new AddGerechtView());
        }
        public void DeleteGerecht()
        {
            if (SelectedGerecht != null)
            {
                DataStore.DeleteGerecht(SelectedGerecht);
                GetData();
                SelectedGerecht = null;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Delete", "Geen Item Geselcteerd", "Ok");
            }
        }
        public void OnAppearing()
        {
            GetData();
        }


        public void BerekenTotaal()
        {
            BerekenIsEnabled = false;

            foreach (Gerecht gerecht in GerechtList)
            {
             
                ItemsTotaal = 0;

                GerechtList.Sum(g => g.Prijs);
                Debug.WriteLine("*****" + ItemsTotaal + "*********");
                ItemsTotaal = GerechtList.Sum(g => g.Prijs);
                App.Current.MainPage.DisplayAlert("Bedankt", "Uw bestelling wordt doorgegeven .. Te betalen: " + ItemsTotaal + " euro.", "OK");
                
            }  
            App.Current.MainPage.DisplayPromptAsync("Tafelnummer", "Tafelnummer ingeven AUB", initialValue: "", keyboard: Keyboard.Numeric);  
            DataStore.GerechtList.Clear();
        }

    }
}
