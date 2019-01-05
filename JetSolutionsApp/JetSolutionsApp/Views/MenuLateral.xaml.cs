using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JetSolutionsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : ContentPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void ChamaCliente(object sender, EventArgs e)
        {
            App.Naveg.Detail = new NavigationPage(new CadastroCli());
            App.Naveg.IsPresented = false;

        }
        private void ChamaAero(object sender, EventArgs e)
        {
            App.Naveg.Detail = new NavigationPage(new AeroportoView());
            App.Naveg.IsPresented = false;
        }
        private void ChamaCombu(object sender, EventArgs e)
        {
            App.Naveg.Detail = new NavigationPage(new CombustivelView());
            App.Naveg.IsPresented = false;

        }
        private void ChamaEmpresa(object sender, EventArgs e)
        {
            App.Naveg.Detail = new NavigationPage(new CadastroEmp());
            App.Naveg.IsPresented = false;
        }
        private void ChamaOS(object sender, EventArgs e)
        {
            App.Naveg.Detail = new NavigationPage(new Servicos());
            App.Naveg.IsPresented = false;

        }
        private void ChamaSumo(object sender, EventArgs e)
        {
            App.Naveg.Detail = new NavigationPage(new Insumos());
            App.Naveg.IsPresented = false;
        }
    }
}
