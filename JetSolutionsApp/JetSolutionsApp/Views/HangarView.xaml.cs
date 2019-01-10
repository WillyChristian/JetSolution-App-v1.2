using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JetSolutionsApp.Models;

namespace JetSolutionsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HangarView : ContentPage
    {
        private List<Hangar> Hangares { get; set; }
        public HangarView()
        {
            InitializeComponent();

            Hangares = new List<Hangar>()
            {
                new Hangar{NomeHangar="hangar01",Airport = "Cumbica",PrecoDiaria=1000.00 },
                new Hangar{NomeHangar="hangar02",Airport = "Cumbica" , PrecoDiaria=950.00},
                new Hangar{NomeHangar="hangar02",Airport = "Cumbica", PrecoDiaria=1025 },
                new Hangar{NomeHangar="hangar01",Airport = "Professor Urbano Ernesto Stumpf" ,PrecoDiaria=1200.00},
                new Hangar{NomeHangar="hangar02",Airport = "Professor Urbano Ernesto Stumpf", PrecoDiaria=1100.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Congonhas", PrecoDiaria=1000.00 },
                new Hangar{NomeHangar="hangar02",Airport = "Congonhas", PrecoDiaria=1500.00},
                new Hangar{NomeHangar="hangar03",Airport = "Congonhas", PrecoDiaria=1051.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Galeão" ,PrecoDiaria=980.00},
                new Hangar{NomeHangar="hangar02",Airport = "Galeão", PrecoDiaria=990.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Jacarepagua",PrecoDiaria=1010.00 },
                new Hangar{NomeHangar="hangar02",Airport = "Jacarepagua" , PrecoDiaria=1150.00},
                new Hangar{NomeHangar="hangar01",Airport = "Guararapes",PrecoDiaria=1000.00 },
                new Hangar{NomeHangar="hangar02",Airport = "Guararapes",PrecoDiaria=880.00 },
                new Hangar{NomeHangar="hangar03",Airport = "Guararapes", PrecoDiaria=900.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Porto Alegre",PrecoDiaria=940.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Pinto Martins Intl",PrecoDiaria=998.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Bacacheri", PrecoDiaria=1400.00 },
                new Hangar{NomeHangar="hangar02",Airport = "Bacacheri", PrecoDiaria=1350.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Viracopos", PrecoDiaria=1130.00 },
                new Hangar{NomeHangar="hangar02",Airport = "Viracopos",PrecoDiaria=1125.00 },
                new Hangar{NomeHangar="hangar03",Airport = "Viracopos",PrecoDiaria=1500.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Confins", PrecoDiaria=1410.00 },
                new Hangar{NomeHangar="hangar01",Airport = "Brasília",PrecoDiaria=1160.00 },
            };

            Hangar h = new Hangar();
            String NomeHangar = string.Format(h.NomeHangar + "   Diária  R$ {0}", h.PrecoDiaria);
            this.ListaHangar.ItemsSource = Hangares;
           // this.BindingContext = this;
        }

        private void ItemSelectList(object sender, ItemTappedEventArgs e)
        {
            var h = (Hangar)e.Item;
            DisplayAlert("Selecionado", String.Format("{0}  -  {1}  Valor da diária - R$ {2}.", h.NomeHangar, h.Airport, h.PrecoDiaria), "Confirmar");
        }

        private void StartDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            LblStartDate.Text = e.NewDate.ToString("dd/MM/yyyy");
            Calculate();
        }

        private void EndDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            LblEndDate.Text = e.NewDate.ToString("dd/MM/yyyy");
            Calculate();
        }
        
       
        void Calculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;

          
                LblResultDays.Text = String.Format("Período de {0}  dias",
                                                    timeSpan.Days);
            
        }
    }
}