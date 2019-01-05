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
    public partial class CadastroCli : ContentPage
    {
        public CadastroCli()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void CriaCad(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage = new NavigationPage(new Menu.ControleMaster());
        }
    }
}