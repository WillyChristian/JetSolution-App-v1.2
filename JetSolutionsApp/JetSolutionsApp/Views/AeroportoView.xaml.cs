using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JetSolutionsApp.Models;
using System;

namespace JetSolutionsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AeroportoView : ContentPage
    {
        public List<Aeroporto> Aeroportos { get; set; }


        public AeroportoView()
        {
            InitializeComponent();

            Aeroportos = new List<Aeroporto>
            {
                new Aeroporto {Nome_Aeropoto="Cumbica",  Municipio = "Guarulhos", Estado = "SP", IATA="GRU", ICAO="SBGR"},
                new Aeroporto{Nome_Aeropoto="Professor Urbano Ernesto Stumpf", Municipio="São José dos Campos", Estado="SP", IATA ="SJC", ICAO="SBSJ"},
                 new Aeroporto {Nome_Aeropoto="Congonhas", Municipio = "São paulo", Estado = "SP", IATA="CGH", ICAO="SBSP"},
                new Aeroporto{Nome_Aeropoto="Teresina", Municipio="Teresina", Estado="PI", IATA ="STHE", ICAO="SBTE"},
                 new Aeroporto {Nome_Aeropoto="São Luís", Municipio = "São Luis", Estado = "MA", IATA="SLZ", ICAO="SBSL"},
                new Aeroporto{Nome_Aeropoto="Galeão", Municipio="Rio de Janeiro", Estado="RJ", IATA ="GIG", ICAO="SBGL"},
                 new Aeroporto {Nome_Aeropoto="Jacarepagua", Municipio = "Rio de Janeiro", Estado = "RJ", IATA="SDU", ICAO="SBRJ"},
                new Aeroporto{Nome_Aeropoto="Guararapes", Municipio="Recife", Estado="PE", IATA ="REC", ICAO="SBRF"},
                 new Aeroporto {Nome_Aeropoto="Porto Alegre", Municipio = "Porto Alegre", Estado = "RS", IATA="POA", ICAO="SBPA"},
                new Aeroporto{Nome_Aeropoto="Pinto Martins Intl", Municipio="Fortaleza", Estado="CE", IATA ="FOR", ICAO="SBFZ"},
                 new Aeroporto {Nome_Aeropoto="Bacacheri", Municipio = "Curitiba", Estado = "PR", IATA="BFH", ICAO="SBBI"},
                new Aeroporto{Nome_Aeropoto="Viracopos", Municipio="Campinas", Estado="SP", IATA ="VCP", ICAO="SBKP"},
                new Aeroporto{Nome_Aeropoto="Confins", Municipio="Belo Horizonte", Estado="SP", IATA ="CNF", ICAO="SBBH"},
                new Aeroporto{Nome_Aeropoto="Brasília", Municipio="Brasília", Estado="DF", IATA ="BSB", ICAO="SBBR"}
            };
            BindingContext = this;
         
        }

    

        private void TocarItem(object sender, ItemTappedEventArgs e)
        {
            var Airport = (Aeroporto)e.Item;
            DisplayAlert("Destino", string.Format("O seu destino será o Aeroporto {0} em {1} / {2};  IATA - {3},  ICAO  {4}", Airport.Nome_Aeropoto, Airport.Municipio, Airport.Estado, Airport.IATA, Airport.ICAO), "Confirmar");
        }
    }
}