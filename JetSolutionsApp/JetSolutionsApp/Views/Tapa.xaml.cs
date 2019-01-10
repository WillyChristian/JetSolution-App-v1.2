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
    public partial class Tapa : ContentPage
    {
        public Tapa()
        {
            InitializeComponent();
        }

        private void Button_ClickedTapa(object sender, EventArgs e)
        {
            DisplayAlert("Avaliação", "Nome: " + EtrTapaName + " - " + EditorTapaTxt, "OK");
            
            EtrTapaName.Text = null;
            EditorTapaTxt.Text = null;
        }    
    }
}