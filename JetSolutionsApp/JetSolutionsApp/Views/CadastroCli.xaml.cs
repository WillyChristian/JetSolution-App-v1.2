using System;
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

        private void CriaCad(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Menu.Controle();
        }
    }
}