using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JetSolutionsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void CriaCadastro(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Views.CadastroCli());
        }
    }
}
