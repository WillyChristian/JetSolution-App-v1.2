using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JetSolutionsApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            
        }
        private void ChamaCli(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new CadastroCli());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaEmpresa(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new CadastroEmp());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaOS(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushModalAsync(new Servicos());
            Application.Navegacao.IsPresented = false;
        }
        
        //private void ChamaConfig(object sender, EventArgs e)
        //{
        //    Application.Navegacao.Detail.Navigation.PushAsync(new Config());
        //    Application.Navegacao.IsPresented = false;
        //}

    }  

       
}