using System;
using Xamarin.Forms;

namespace JetSolutionsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CriaCadastro.Clicked += (sender, e) => Xamarin.Forms.Application.Current.MainPage = new Views.CadastroCli();
        }
        
    }
}
