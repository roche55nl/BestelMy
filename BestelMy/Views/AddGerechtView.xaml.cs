using BestelMy.Models;
using BestelMy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BestelMy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddGerechtView : ContentPage
    {
       
        public AddGerechtView()
        {

            InitializeComponent();
           
            BindingContext = new AddGerechtViewmodel();
          
        }
        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Gerecht;
            await Navigation.PushAsync(new ListPageDetailView(details.Naam, details.Description, details.Image));
        }
        private void StepperCounter_ValueChanged(object sender, ValueChangedEventArgs e)
        {
    
            txtItemsCount.Text = e.NewValue.ToString();
           
        }
    }
}