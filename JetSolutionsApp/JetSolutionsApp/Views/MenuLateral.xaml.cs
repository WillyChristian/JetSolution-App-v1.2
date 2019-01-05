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
            Application.Naveg.Detail = new NavigationPage(new CadastroCli());
            Application.Naveg.IsPresented = false;

        }
        private void ChamaAero(object sender, EventArgs e)
        {
            Application.Naveg.Detail = new NavigationPage(new AeroportoView());
            Application.Naveg.IsPresented = false;
        }
        private void ChamaCombu(object sender, EventArgs e)
        {
            Application.Naveg.Detail = new NavigationPage(new CombustivelView());
            Application.Naveg.IsPresented = false;

        }
        private void ChamaEmpresa(object sender, EventArgs e)
        {
            Application.Naveg.Detail = new NavigationPage(new CadastroEmp());
            Application.Naveg.IsPresented = false;
        }
        private void ChamaOS(object sender, EventArgs e)
        {
            Application.Naveg.Detail = new NavigationPage(new Servicos());
            Application.Naveg.IsPresented = false;

        }
        private void ChamaSumo(object sender, EventArgs e)
        {
            Application.Naveg.Detail = new NavigationPage(new Insumos());
            Application.Naveg.IsPresented = false;
        }
    }
}
