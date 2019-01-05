using System;
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
            Application.Current.MainPage = new NavigationPage(new Views.CadastroCli());
        }
    }
}
