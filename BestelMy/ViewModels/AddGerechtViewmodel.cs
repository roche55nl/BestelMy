using BestelMy.Models;
using BestelMy.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BestelMy.ViewModels
{
    class AddGerechtViewmodel : BaseViewmodel
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Gerecht SelectedMyList { get; set; }
       
        public Command AddCommand { get; set; }
        public ObservableCollection<Gerecht> GerechtList { get; set; }
       
        public AddGerechtViewmodel()
        {
            PageTitle = "Menu";
           
             AddCommand = new Command(AddGerecht);
            GerechtList = new ObservableCollection<Gerecht>();
            GerechtList.Add(new Gerecht() { Naam = "Pizza Salami", Prijs = 12, Description = " Tomaat kaas Salami. Een typisch Napolitaanse pizza met als ingrediënten tomaten, mozzarella en verse basilicum. ", Image = "https://milanoweimar.de/wp-content/uploads/pizza-salami-360x360.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Mafiosa", Prijs = 11.65, Description = "Tomaat, kaas, Ham en Ananas", Image = "https://milanoweimar.de/wp-content/uploads/pizza-barbecue-bacon.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Grandisima", Prijs = 14.25, Description = "Tomatensaus, mozzarella, pikante salami, paprika, olijven, artisjok, spiegelei, ajuin en pikante olijfolie", Image = "https://milanoweimar.de/wp-content/uploads/pizza-kreta.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Vier Kaas", Prijs = 15.75, Description = "Tomaten, mozzarella, ham, spek, pikante salami, aubergine, pikante saus", Image = "https://milanoweimar.de/wp-content/uploads/pizza-quattro-formaggi.png" });
             GerechtList.Add(new Gerecht() { Naam = "Pizza Caprese", Prijs = 13.45, Description = "Tomaat, kaas, Mozzarella Basilicum", Image = "https://milanoweimar.de/wp-content/uploads/pizza-tomate-mozzarella.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Tonno", Prijs = 12.57, Description = "Tomatensaus, mozzarella, gamba’s, courgette, gerookte zalm, verse tomaten, verse basilicum en look ", Image = "https://milanoweimar.de/wp-content/uploads/pizza-vier-jahreszeiten.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Regalo", Prijs = 16.25, Description = "Tomaat, kaas, Mozzarella Basilicum", Image = "https://milanoweimar.de/wp-content/uploads/vegetarische-pizza.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Principessa", Prijs = 11.95, Description = "Tomaat, kaas, Mozzarella Basilicum", Image = "https://milanoweimar.de/wp-content/uploads/pizza-thunfisch.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Marinara", Prijs = 13.65, Description = "Tomaat, kaas, Mozzarella Basilicum", Image = "https://milanoweimar.de/wp-content/uploads/pizza-spinaccio.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Proscuito", Prijs = 11.75, Description = "Tomaat, kaas, Mozzarella Basilicum", Image = "https://milanoweimar.de/wp-content/uploads/pizza-magherita.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Di Mamma", Prijs = 16, Description = "tomatensaus, mozzarella, look, grijze garnalen, mosselen, vongole, kappertjes", Image = "https://milanoweimar.de/wp-content/uploads/pizza-meeresfr%C3%BCchte.png" });
            GerechtList.Add(new Gerecht() { Naam = "Pizza Amsterdam", Prijs = 15.25, Description = "Tomatensaus, mozzarella, ham, champignons, paprika, courgette en verse tomaten", Image = "https://milanoweimar.de/wp-content/uploads/Pizza-Amsterdam.png" });
        }


        public void AddGerecht()
        {
           
            if (SelectedMyList != null)
            {
                DataStore.AddGerecht(SelectedMyList);
            }
            else
            {

                App.Current.MainPage.DisplayAlert("Let op!", "U heeft nog niets geselecteerd", "Ok!");
                App.Current.MainPage.Navigation.PushAsync(new AddGerechtView());
            }

            App.Current.MainPage.Navigation.PopAsync();
        }
    }


}
