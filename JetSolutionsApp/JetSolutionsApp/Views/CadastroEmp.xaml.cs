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
    public partial class CadastroEmp : ContentPage
    {
        public CadastroEmp()
        {
            InitializeComponent();
        }
        private void CriaCadastro(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.Menu.ControleMaster();
        }
    }
}