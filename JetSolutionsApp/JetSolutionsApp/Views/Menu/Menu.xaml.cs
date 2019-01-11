using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.CadastroCli());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaEmpresa(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.CadastroEmp());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaOS(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.Servicos());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaHan(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.HangarView());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaSumo(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.InsumoView());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaCombu(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.CombustivelView());
            Application.Navegacao.IsPresented = false;
        }
        private void ChamaAero(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.AeroportoView());
            Application.Navegacao.IsPresented = false;
        }

        private void ChamaTapa(object sender, EventArgs e)
        {
            Application.Navegacao.Detail.Navigation.PushAsync(new Views.Tapa());
            Application.Navegacao.IsPresented = false; ;
        }
    }
}