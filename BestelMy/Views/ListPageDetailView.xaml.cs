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
    public partial class ListPageDetailView : ContentPage
    {
        public ListPageDetailView(string Name, string Description, string source)
        {
            InitializeComponent();

            MyTitle.Text = Name;
            MyDesc.Text = Description;
            MyImage.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }
    }
}