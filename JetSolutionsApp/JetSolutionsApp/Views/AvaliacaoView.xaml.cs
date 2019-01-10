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
    public partial class AvaliacaoView : ContentPage
    {
        public AvaliacaoView()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            NotaAvaliacao.Text = e.NewValue.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var nota = string.Format(NotaAvaliacao.Text);
            var nome = string.Format(EtrName.Text);
            var editor = string.Format(EditorTxt.Text);
            DisplayAlert("Avaliação", "Nota: " + nota + " Nome: " + nome + " - " + editor, "OK");
            NotaAvaliacao.Text= "0";
            EtrName.Text = null;
            EditorTxt.Text = null;
        }
    }
}