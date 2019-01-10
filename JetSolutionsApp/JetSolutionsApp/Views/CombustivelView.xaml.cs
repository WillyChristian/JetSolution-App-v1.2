using System;
using System.Collections.Generic;
using JetSolutionsApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JetSolutionsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CombustivelView : ContentPage
    {
        Combustivel C = new Combustivel();
        List<Combustivel> Fornecedores { get; set; }
        public CombustivelView()
        {
            InitializeComponent();

            Fornecedores = new List<Combustivel>
            {

               new Combustivel{Distribuidor="Shell", Fornecedor = "Fornecedor1", Preco = 3.6, Total_Combustivel = 0.0, url="https://www.shellaviacao.com.br"},
               new Combustivel{Distribuidor="BR" ,Fornecedor = "Fornecedor2", Preco = 3.63, Quantidade = 0.0, Total_Combustivel = 0.0 },
               new Combustivel{Distribuidor="Outro",  Fornecedor = "Fornecedor3", Preco = 3.59, Quantidade = 0.0, Total_Combustivel = 0.0 }


            };

            this.BindingContext = this;
            this.ListaFornecedores.ItemsSource = this.Fornecedores;
        }
        public void Button_Clicked(object sender, EventArgs e)
        {

            string nome = Convert.ToString(C.Distribuidor);
            Button btn = (Button)sender;
            Combustivel comb = (Combustivel)btn.CommandParameter;
            DisplayAlert("Aviso", "Visitar o site " + nome, "cacelar", "reservar");
        }
    }
}