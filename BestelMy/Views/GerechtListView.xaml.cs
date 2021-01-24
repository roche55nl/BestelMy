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
    public partial class GerechtListView : ContentPage
    {
        GerechtListViewmodel _viewmodel;
        public GerechtListView()
        {
            InitializeComponent();
            BindingContext = _viewmodel = new GerechtListViewmodel();
           
        }
        protected override void OnAppearing()
        {
            _viewmodel.OnAppearing();
        } 
    }
}