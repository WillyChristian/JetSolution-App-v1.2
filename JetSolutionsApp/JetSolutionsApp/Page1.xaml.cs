using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JetSolutionsApp.Views;

namespace JetSolutionsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new AeroportoView());
        }

        private async void Button_Clicked_0(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsumoView());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CombustivelView());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsumoView());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tapa());
        }


        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AvaliacaoView());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HangarView());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mapa());
        }
    }
}