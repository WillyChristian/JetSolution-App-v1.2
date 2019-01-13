using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JetSolutionsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Servicos : ContentPage
    {
        public Servicos()
        {
            InitializeComponent();
        }

        private async void BtAirport(object sender, EventArgs e) => await Navigation.PushAsync(new AeroportoView());
        private async void BtJetFuel(object sender, EventArgs e) => await Navigation.PushAsync(new CombustivelView());
        private async void BtMapa(object sender, EventArgs e) => await Navigation.PushAsync(new Mapa());
        private async void BtDica(object sender, EventArgs e) => await Navigation.PushAsync(new Tapa());
             
    }
}