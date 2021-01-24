using BestelMy.Services;
using BestelMy.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BestelMy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new GerechtListView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
